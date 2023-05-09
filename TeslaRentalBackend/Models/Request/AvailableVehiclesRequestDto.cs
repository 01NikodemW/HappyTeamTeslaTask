namespace TeslaRentalBackend.Models.Request;

public class AvailableVehiclesRequestDto
{
    public DateTime RentalDate { get; set; }
    public DateTime ReturnDate { get; set; }
}