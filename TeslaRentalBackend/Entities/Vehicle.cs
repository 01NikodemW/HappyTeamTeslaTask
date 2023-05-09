using TeslaRentalBackend.Enum;

namespace TeslaRentalBackend.Entities;

public class Vehicle
{
    public Guid Id { get; set; }
    public TeslaModel Model { get; set; }
    public float Mileage { get; set; }
    public string ImageUrl { get; set; } = default!;
    public int RentalPricePerDay { get; set; }
}