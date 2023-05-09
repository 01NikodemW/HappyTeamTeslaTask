namespace TeslaRentalBackend.Models.Request;

public class RegisterRequestDto
{
    public string Email { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string PasswordConfirmation { get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public Guid CountryId { get; set; }
}