using FluentValidation;
using Microsoft.EntityFrameworkCore;

using TeslaRentalBackend.Entities;

namespace TeslaRentalBackend.Models.Request.Validators;

public class ReservationRequestDtoValidator : AbstractValidator<ReservationRequestDto>
{
    public ReservationRequestDtoValidator(TeslaRentalDbContext dbContext)
    {
        RuleFor(x => x.RentalDate.Date)
            .NotEmpty().WithMessage("'{PropertyName}' cannot be empty")
            .Must((rentalDate) => rentalDate >= DateTime.Now.Date)
            .WithMessage("'{PropertyName}' must be in the future");

        RuleFor(x => x.ReturnDate.Date)
            .NotEmpty().WithMessage("'{PropertyName}' cannot be empty")
            .GreaterThanOrEqualTo(x => x.RentalDate.Date)
            .WithMessage("'{PropertyName}' must be greater than '{ComparisonValue}'")
            .Must((returnDate) => returnDate >= DateTime.Now.Date)
            .WithMessage("'{PropertyName}' must be in the future");

        RuleFor(x => x.VehicleId).NotEmpty()
            .WithMessage("'{PropertyName}' cannot be empty")
            .MustAsync(async (vehicleId, cancellation) =>
            {
                var vehicle = await dbContext.Vehicles.FirstOrDefaultAsync(x => x.Id == vehicleId);
                return vehicle != null;
            })
            .WithMessage("Vehicle does not exist.");


        RuleFor(x => x.RentalLocationId).NotEmpty()
            .WithMessage("'{PropertyName}' cannot be empty")
            .MustAsync(async (rentalLocationId, cancellation) =>
            {
                var rentalLocation = await dbContext.Locations.FirstOrDefaultAsync(x => x.Id == rentalLocationId);
                return rentalLocation != null;
            })
            .WithMessage("Rental location does not exist.");

        RuleFor(x => x.ReturnLocationId).NotEmpty()
            .WithMessage("'{PropertyName}' cannot be empty")
            .MustAsync(async (returnLocationId, cancellation) =>
            {
                var returnLocation = await dbContext.Locations.FirstOrDefaultAsync(x => x.Id == returnLocationId);
                return returnLocation != null;
            })
            .WithMessage("Return location does not exist.");
    }
}