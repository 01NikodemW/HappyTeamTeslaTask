using TeslaRentalBackend.Models.Response;

namespace TeslaRentalBackend.Services;

public interface ICountryService
{
    Task<IEnumerable<CountryResponseDto>> GetAllCountriesAsync();
}