using TeslaRentalBackend.Models.Response;

namespace TeslaRentalBackend.Services;

public interface ILocationService
{
    Task<IEnumerable<LocationResponseDto>> GetAllLocationsAsync();
}