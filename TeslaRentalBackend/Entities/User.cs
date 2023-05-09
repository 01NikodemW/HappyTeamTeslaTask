namespace TeslaRentalBackend.Entities;

public class User
{
    public Guid Id { get; set; }
    public string Email { get; set; } = default!;
    public string PasswordHash { get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public Guid CountryId { get; set; }
    public virtual Country Country { get; set; } = default!;
}