using FluentValidation;

namespace LanosCertifiedStore.Application.Vehicles.Commands.CreateVehicleCommandRequestRelated;

internal sealed class CreateVehicleCommandRequestValidator : AbstractValidator<CreateVehicleCommandRequest>
{
    public CreateVehicleCommandRequestValidator()
    {
        GetDescriptionValidationRules();
        GetNumericValueValidationRules();
        GetIdentifierValidationRules();
        GetVinCodeValidationRules();
        GetTypeValidationRules();
    }

    private void GetDescriptionValidationRules()
    {
        RuleFor(x => x.Description)
            .NotEmpty()
            .MinimumLength(20)
            .MaximumLength(3000)
            .WithMessage(VehicleValidatorMessages.InvalidDescription);
    }

    private void GetNumericValueValidationRules()
    {
        RuleFor(x => x.Price)
            .NotEmpty()
            .GreaterThan(0)
            .WithMessage(VehicleValidatorMessages.InvalidPrice);
        
        RuleFor(x => x.Displacement)
            .NotEmpty()
            .GreaterThan(0)
            .WithMessage(VehicleValidatorMessages.InvalidDisplacement);
        
        RuleFor(x => x.Mileage)
            .NotEmpty()
            .GreaterThanOrEqualTo(0)
            .WithMessage(VehicleValidatorMessages.InvalidMileage);
    }

    private void GetIdentifierValidationRules()
    {
        RuleFor(x => x.ModelId)
            .NotEmpty()
            .NotNull()
            .WithMessage(VehicleValidatorMessages.ModelRequired);
        
        RuleFor(x => x.BrandId)
            .NotEmpty()
            .NotNull()
            .WithMessage(VehicleValidatorMessages.BrandRequired);
        
        RuleFor(x => x.ColorId)
            .NotEmpty()
            .NotNull()
            .WithMessage(VehicleValidatorMessages.ColorRequired);
        
        RuleFor(x => x.LocationTownId)
            .NotEmpty()
            .NotNull()
            .WithMessage(VehicleValidatorMessages.TownRequired);
    }

    private void GetVinCodeValidationRules()
    {
        RuleFor(x => x.Vincode)
            .NotEmpty()
            .WithMessage(VehicleValidatorMessages.VinRequired);
        
        RuleFor(x => x.Vincode)
            .MaximumLength(17)
            .MinimumLength(17)
            .WithMessage(VehicleValidatorMessages.InvalidVinLength);
    }

    private void GetTypeValidationRules()
    {
        RuleFor(x => x.BodyTypeId)
            .NotEmpty()
            .NotNull()
            .WithMessage(VehicleValidatorMessages.BodyTypeRequired);
        
        RuleFor(x => x.EngineTypeId)
            .NotEmpty()
            .NotNull()
            .WithMessage(VehicleValidatorMessages.EngineTypeRequired);
        
        RuleFor(x => x.TransmissionTypeId)
            .NotEmpty()
            .NotNull()
            .WithMessage(VehicleValidatorMessages.TransmissionTypeRequired);
        
        RuleFor(x => x.DrivetrainTypeId)
            .NotEmpty()
            .NotNull()
            .WithMessage(VehicleValidatorMessages.DrivetrainTypeRequired);
    }
}