using FluentValidation;
using FluentValidation.Results;
using Mapster;
using Microsoft.EntityFrameworkCore;
using TeslaRentalBackend.Entities;
using TeslaRentalBackend.Exceptions;
using TeslaRentalBackend.Models;
using TeslaRentalBackend.Models.Request;
using TeslaRentalBackend.Models.Response;

namespace TeslaRentalBackend.Services;

public class ReservationService : IReservationService
{
    private readonly TeslaRentalDbContext _context;

    public ReservationService(TeslaRentalDbContext context)
    {
        _context = context;
    }

    public async Task ReserveVehicle(ReservationRequestDto requestDto, Guid userId)
    {
        var reservationDates = GetReservationDatesByVehicle(requestDto.VehicleId);

        foreach (var reservationDate in reservationDates)
        {
            if (requestDto.RentalDate.Date >= reservationDate.RentalDate.Date &&
                requestDto.RentalDate.Date <= reservationDate.ReturnDate.Date)
            {
                throw new ReservationException("Vehicle is already reserved for this date");
            }

            if (requestDto.ReturnDate.Date >= reservationDate.RentalDate.Date &&
                requestDto.ReturnDate.Date <= reservationDate.ReturnDate.Date)
            {
                throw new ReservationException("Vehicle is already reserved for this date");
            }


            if (requestDto.RentalDate.Date <= reservationDate.RentalDate.Date &&
                requestDto.ReturnDate.Date >= reservationDate.ReturnDate.Date)
            {
                throw new ReservationException("Vehicle is already reserved for this date");
            }
        }

        var vehicle = await _context.Vehicles
            .FirstAsync(x => x.Id == requestDto.VehicleId);


        var timeSpan = requestDto.ReturnDate.Date - requestDto.RentalDate.Date;
        var totalPeriod = (int)timeSpan.TotalDays + 1;
        var totalPrice = totalPeriod * vehicle.RentalPricePerDay;


        var reservation = requestDto.Adapt<Reservation>();
        reservation.UserId = userId;
        reservation.TotalPrice = totalPrice;

        _context.Reservations.Add(reservation);
        await _context.SaveChangesAsync();
    }

    private IEnumerable<ReservationDateDto> GetReservationDatesByVehicle(Guid vehicleId)
    {
        var reservations = _context.Reservations
            .Where(x => x.VehicleId == vehicleId)
            .ProjectToType<ReservationDateDto>()
            .ToList();

        return reservations;
    }


    public async Task<IEnumerable<ReservationResponseDto>> GetReservationsByUserId(Guid userId)
    {
        var reservations = await _context.Reservations
            .ProjectToType<ReservationResponseDto>()
            .Where(x => x.UserId == userId)
            .ToListAsync();


        var reservationsResponseDto = reservations.Adapt<IEnumerable<ReservationResponseDto>>().ToList();

        return reservationsResponseDto;
    }
}