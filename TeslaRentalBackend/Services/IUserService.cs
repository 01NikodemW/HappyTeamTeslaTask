using TeslaRentalBackend.Models.Request;

namespace TeslaRentalBackend.Services;

public interface IUserService
{
    Task RegisterAsync(RegisterRequestDto dto);
    Task<string> LoginAsync(LoginRequestDto requestDto);
}