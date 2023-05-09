using Microsoft.AspNetCore.Identity;
using TeslaRentalBackend.Entities;
using System.Security.Claims;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TeslaRentalBackend.Models.Request;

namespace TeslaRentalBackend.Services;

public class UserService : IUserService
{
    private readonly TeslaRentalDbContext _dbContext;
    private readonly IPasswordHasher<User> _passwordHasher;
    private readonly AuthenticationSettings _authenticationSettings;

    public UserService(TeslaRentalDbContext dbContext,
        IPasswordHasher<User> passwordHasher,
        IOptions<AuthenticationSettings> authenticationSettings)
    {
        _dbContext = dbContext;
        _passwordHasher = passwordHasher;
        _authenticationSettings = authenticationSettings.Value;
    }


    public async Task RegisterAsync(RegisterRequestDto dto)
    {
        var newUser = new User()
        {
            Email = dto.Email,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            CountryId = dto.CountryId,
        };
        var passwordHash = _passwordHasher.HashPassword(newUser, dto.Password);
        newUser.PasswordHash = passwordHash;
        _dbContext.Users.Add(newUser);
        await _dbContext.SaveChangesAsync();
    }


    public async Task<string> LoginAsync(LoginRequestDto requestDto)
    {
        var user = await _dbContext.Users
            .FirstOrDefaultAsync(u => u.Email == requestDto.Email);

        if (user is null)
        {
            throw new Exception("Invalid username or password");
        }

        var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, requestDto.Password);
        if (result == PasswordVerificationResult.Failed)
        {
            throw new Exception("Invalid username or password");
        }

        var claims = new List<Claim>()
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Email, user.Email.ToString()),
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authenticationSettings.JwtKey));
        var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var expires = DateTime.Now.AddDays(_authenticationSettings.JwtExpireDays);

        var token = new JwtSecurityToken(_authenticationSettings.JwtIssuer,
            _authenticationSettings.JwtIssuer,
            claims,
            expires: expires,
            signingCredentials: cred);

        var tokenHandler = new JwtSecurityTokenHandler();
        return tokenHandler.WriteToken(token);
    }
}