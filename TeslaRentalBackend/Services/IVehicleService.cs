using TeslaRentalBackend.Models.Request;
using TeslaRentalBackend.Models.Response;

namespace TeslaRentalBackend.Services;

public interface IVehicleService
{
    Task<IEnumerable<VehicleResponseDto>> GetAvailableVehicles(AvailableVehiclesRequestDto requestDto);
}