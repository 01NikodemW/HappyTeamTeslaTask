using TeslaRentalBackend.Enum;

namespace TeslaRentalBackend.Models.Response;

public class VehicleResponseDto
{
    public Guid Id { get; set; }
    public TeslaModel Model { get; set; }
    public float Mileage { get; set; }
    public string ImageUrl { get; set; } = default!;
    public float RentalPricePerDay { get; set; }
}