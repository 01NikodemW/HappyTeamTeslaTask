using TeslaRentalBackend.Models.Request;
using TeslaRentalBackend.Models.Response;

namespace TeslaRentalBackend.Services;

public interface IReservationService
{
    Task ReserveVehicle(ReservationRequestDto requestDto, Guid userId);
    Task<IEnumerable<ReservationResponseDto>> GetReservationsByUserId(Guid userId);
}