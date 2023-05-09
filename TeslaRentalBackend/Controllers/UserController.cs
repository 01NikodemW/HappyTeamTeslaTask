using Microsoft.AspNetCore.Mvc;
using TeslaRentalBackend.Entities;
using TeslaRentalBackend.Models.Request;
using TeslaRentalBackend.Models.Request.Validators;
using TeslaRentalBackend.Services;

namespace TeslaRentalBackend.Controllers;

[Route("[controller]"), ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly TeslaRentalDbContext _dbContext;


    public UserController(IUserService userService, TeslaRentalDbContext dbContext)
    {
        _userService = userService;
        _dbContext = dbContext;
    }


    [HttpPost("[action]")]
    public async Task<ActionResult> Register([FromBody] RegisterRequestDto requestDto)
    {
        var validator = new RegisterRequestDtoValidator(_dbContext);
        var validationResult = await validator.ValidateAsync(requestDto);
        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.ToString());
        }

        await _userService.RegisterAsync(requestDto);
        return Ok();
    }


    [HttpPost("[action]")]
    public async Task<ActionResult> Login([FromBody] LoginRequestDto requestDto)
    {
        var validator = new LoginRequestDtoValidator();
        var validationResult = await validator.ValidateAsync(requestDto);
        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.ToString());
        }

        var token = await _userService.LoginAsync(requestDto);
        return Ok(token);
    }
}