namespace TeslaRentalBackend;

public class AuthenticationSettings
{
    public static string SectionName = "Authentication";
    public string JwtKey { get; set; } = default!;

    public int JwtExpireDays { get; set; }

    public string JwtIssuer { get; set; } = default!;
}