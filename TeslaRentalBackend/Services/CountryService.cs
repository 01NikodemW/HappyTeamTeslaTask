using Mapster;
using Microsoft.EntityFrameworkCore;
using TeslaRentalBackend.Entities;
using TeslaRentalBackend.Models.Response;

namespace TeslaRentalBackend.Services;

public class CountryService : ICountryService
{
    private readonly TeslaRentalDbContext _context;

    public CountryService(TeslaRentalDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<CountryResponseDto>> GetAllCountriesAsync()
    {
        var countries = await _context.Countries.ToListAsync();

        var countriesResponseDto = countries.Adapt<IEnumerable<CountryResponseDto>>();
        return countriesResponseDto;
    }
}