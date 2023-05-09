using Mapster;
using Microsoft.EntityFrameworkCore;
using TeslaRentalBackend.Entities;
using TeslaRentalBackend.Models.Response;

namespace TeslaRentalBackend.Services;

public class LocationService : ILocationService
{
    private readonly TeslaRentalDbContext _context;

    public LocationService(TeslaRentalDbContext context)
    {
        _context = context;
    }


    public async Task<IEnumerable<LocationResponseDto>> GetAllLocationsAsync()
    {
        var locations = await _context.Locations.ToListAsync();
        var locationsResponseDto = locations.Adapt<IEnumerable<LocationResponseDto>>();
        return locationsResponseDto;
    }
}