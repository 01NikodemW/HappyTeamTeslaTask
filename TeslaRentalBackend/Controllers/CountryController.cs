using Microsoft.AspNetCore.Mvc;
using TeslaRentalBackend.Entities;
using TeslaRentalBackend.Services;

namespace TeslaRentalBackend.Controllers;

[Route("[controller]"), ApiController]
public class CountryController : ControllerBase
{
    private readonly ICountryService _countryService;

    public CountryController(ICountryService countryService)
    {
        _countryService = countryService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Country>>> GetAllCountries()
    {
        var countries = await _countryService.GetAllCountriesAsync();
        return Ok(countries);
    }
}