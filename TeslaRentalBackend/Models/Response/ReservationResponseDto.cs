namespace TeslaRentalBackend.Models.Response;

public class ReservationResponseDto
{
    public Guid Id { get; set; } = default!;
    // public UserResponseDto User { get; set; } = default!;
    public Guid UserId { get; set; }
    public VehicleResponseDto Vehicle { get; set; } = default!;
    public LocationResponseDto RentalLocation { get; set; } = default!;
    public LocationResponseDto ReturnLocation { get; set; } = default!;
    public DateTime RentalDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public int TotalPrice { get; set; }
}