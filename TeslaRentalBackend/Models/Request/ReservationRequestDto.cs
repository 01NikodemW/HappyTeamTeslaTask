namespace TeslaRentalBackend.Models.Request;

public class ReservationRequestDto
{
    public Guid VehicleId { get; set; }
    public Guid RentalLocationId { get; set; }
    public Guid ReturnLocationId { get; set; }
    public DateTime RentalDate { get; set; }
    public DateTime ReturnDate { get; set; }
}