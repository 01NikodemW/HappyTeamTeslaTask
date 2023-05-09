namespace TeslaRentalBackend.Entities;

public class Reservation
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public virtual User User { get; set; } = default!;
    public Guid VehicleId { get; set; }
    public virtual Vehicle Vehicle { get; set; } = default!;
    public Guid RentalLocationId { get; set; }
    public virtual Location RentalLocation { get; set; } = default!;
    public Guid ReturnLocationId { get; set; }
    public virtual Location ReturnLocation { get; set; } = default!;
    public DateTime RentalDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public int TotalPrice { get; set; }
}