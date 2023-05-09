using FluentValidation;

namespace TeslaRentalBackend.Models.Request.Validators;

public class AvailableVehiclesRequestDtoValidator : AbstractValidator<AvailableVehiclesRequestDto>
{
    public AvailableVehiclesRequestDtoValidator()
    {
        RuleFor(x => x.RentalDate.Date).NotEmpty();
        RuleFor(x => x.ReturnDate.Date).NotEmpty()
            .GreaterThanOrEqualTo(x => x.RentalDate.Date);
    }
}