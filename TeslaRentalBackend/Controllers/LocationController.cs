using Microsoft.AspNetCore.Mvc;
using TeslaRentalBackend.Models.Response;
using TeslaRentalBackend.Services;

namespace TeslaRentalBackend.Controllers;

[Route("[controller]"), ApiController]
public class LocationController : ControllerBase
{
    private readonly ILocationService _locationService;

    public LocationController(ILocationService locationService)
    {
        _locationService = locationService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<LocationResponseDto>>> GetAllLocations()
    {
        var locations = await _locationService.GetAllLocationsAsync();
        return Ok(locations);
    }
}