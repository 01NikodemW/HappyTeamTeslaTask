using FluentValidation;
using Microsoft.EntityFrameworkCore;
using TeslaRentalBackend.Entities;

namespace TeslaRentalBackend.Models.Request.Validators;

public class RegisterRequestDtoValidator : AbstractValidator<RegisterRequestDto>
{
    public RegisterRequestDtoValidator(TeslaRentalDbContext dbContext)
    {
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("'{PropertyName}' cannot be empty")
            .EmailAddress().WithMessage("'{PropertyName}' must be email type");
        RuleFor(x => x.Email)
            .NotEmpty()
            .MustAsync(async (email, cancellationToken) =>
            {
                var user = await dbContext.Users.FirstOrDefaultAsync(x => x.Email == email);
                return user == null;
            })
            .WithMessage("Email is taken.");


        RuleFor(x => x.Password).MinimumLength(7)
            .Matches("[A-Z]").WithMessage("'{PropertyName}' must contain one or more capital letters.")
            .Matches("[a-z]").WithMessage("'{PropertyName}' must contain one or more lowercase letters.")
            .Matches(@"\d").WithMessage("'{PropertyName}' must contain one or more digits.")
            .Matches(@"^[^\s\r\n]*$").WithMessage("'{PropertyName}' cannot contain whitespace");
        RuleFor(x => x.PasswordConfirmation).Equal(e => e.Password)
            .WithMessage("'{PropertyName}' must match password");
        RuleFor(x => x.FirstName).NotEmpty();
        RuleFor(x => x.LastName).NotEmpty();
        RuleFor(x => x.CountryId)
            .NotEmpty()
            .MustAsync(async (countryId, cancellationToken) =>
            {
                var country = await dbContext.Countries.FirstOrDefaultAsync(x => x.Id == countryId);
                return country != null;
            })
            .WithMessage("Country does not exist.");
    }
}