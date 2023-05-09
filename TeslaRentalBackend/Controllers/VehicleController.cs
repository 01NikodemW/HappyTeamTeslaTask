using Microsoft.AspNetCore.Mvc;
using TeslaRentalBackend.Models.Request;
using TeslaRentalBackend.Models.Request.Validators;
using TeslaRentalBackend.Services;

namespace TeslaRentalBackend.Controllers;

[Route("[controller]"), ApiController]
public class VehicleController : ControllerBase
{
    private readonly IVehicleService _vehicleService;

    public VehicleController(IVehicleService vehicleService)
    {
        _vehicleService = vehicleService;
    }


    [HttpPost("[action]")]
    public async Task<ActionResult> GetAvailableVehicles([FromBody] AvailableVehiclesRequestDto requestDto)
    {
        var validator = new AvailableVehiclesRequestDtoValidator();
        var validationResult = await validator.ValidateAsync(requestDto);
        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.ToString());
        }

        var availableVehicles = await _vehicleService.GetAvailableVehicles(requestDto);
        return Ok(availableVehicles);
    }
}