using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TeslaRentalBackend.Entities;
using TeslaRentalBackend.Models.Request;
using TeslaRentalBackend.Models.Request.Validators;
using TeslaRentalBackend.Models.Response;
using TeslaRentalBackend.Services;

namespace TeslaRentalBackend.Controllers;

[Route("[controller]"), ApiController]
public class ReservationController : ControllerBase
{
    private readonly IReservationService _reservationService;
    private readonly TeslaRentalDbContext _dbContext;

    public ReservationController(IReservationService reservationService, TeslaRentalDbContext dbContext)
    {
        _reservationService = reservationService;
        _dbContext = dbContext;
    }

    [Authorize]
    [HttpPost("[action]")]
    public async Task<ActionResult> ReserveVehicle([FromBody] ReservationRequestDto requestDto)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value ??
                     throw new Exception();

        var validator = new ReservationRequestDtoValidator(_dbContext);
        var validationResult = await validator.ValidateAsync(requestDto);
        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors.Aggregate("", (s, e) => s + e.ErrorMessage + "\n"));
        }

        await _reservationService.ReserveVehicle(requestDto, Guid.Parse(userId));
        return Ok();
    }


    [Authorize]
    [HttpGet("[action]")]
    public async Task<ActionResult<ReservationResponseDto>> GetMyReservations()
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;
        if (userId is null)
        {
            return BadRequest();
        }

        var reservations = await _reservationService.GetReservationsByUserId(Guid.Parse(userId));
        return Ok(reservations);
    }
}