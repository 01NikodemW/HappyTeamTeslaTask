namespace TeslaRentalBackend.Models.Response;

public class UserResponseDto
{
    public Guid Id { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public CountryResponseDto Country { get; set; } = default!;
}