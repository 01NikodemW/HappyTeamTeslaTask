using Mapster;
using Microsoft.EntityFrameworkCore;
using TeslaRentalBackend.Entities;
using TeslaRentalBackend.Models;
using TeslaRentalBackend.Models.Request;
using TeslaRentalBackend.Models.Response;

namespace TeslaRentalBackend.Services;

public class VehicleService : IVehicleService
{
    private readonly TeslaRentalDbContext _dbContext;

    public VehicleService(TeslaRentalDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<VehicleResponseDto>> GetAvailableVehicles(AvailableVehiclesRequestDto requestDto)
    {
        var availableVehicles = new List<Vehicle>();
        var vehicles = await _dbContext.Vehicles.ToListAsync();
        foreach (var vehicle in vehicles)
        {
            var reservationDates = await GetReservationDatesByVehicle(vehicle.Id);
            var isAvailable = true;

            foreach (var reservationDate in reservationDates)
            {
                if (requestDto.RentalDate.Date >= reservationDate.RentalDate.Date &&
                    requestDto.RentalDate.Date <= reservationDate.ReturnDate.Date)
                {
                    isAvailable = false;
                    break;
                }

                if (requestDto.ReturnDate.Date >= reservationDate.RentalDate.Date &&
                    requestDto.ReturnDate.Date <= reservationDate.ReturnDate.Date)
                {
                    isAvailable = false;
                    break;
                }

                if (requestDto.RentalDate.Date <= reservationDate.RentalDate.Date &&
                    requestDto.ReturnDate.Date >= reservationDate.ReturnDate.Date)
                {
                    isAvailable = false;
                    break;
                }
            }

            if (isAvailable)
            {
                availableVehicles.Add(vehicle);
            }
        }


        var availableVehiclesResponseDto = availableVehicles.Adapt<IEnumerable<VehicleResponseDto>>().ToList();

        return availableVehiclesResponseDto;
    }

    private async Task<IEnumerable<ReservationDateDto>> GetReservationDatesByVehicle(Guid vehicleId)
    {
        var reservations = await _dbContext.Reservations
            .Where(x => x.VehicleId == vehicleId)
            .ToListAsync();

        var reservationDates = new List<ReservationDateDto>();

        foreach (var reservation in reservations)
        {
            var reservationDate = new ReservationDateDto()
            {
                RentalDate = reservation.RentalDate,
                ReturnDate = reservation.ReturnDate
            };

            reservationDates.Add(reservationDate);
        }

        return reservationDates;
    }
}