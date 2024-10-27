using FluentValidation;

namespace LanosCertifiedStore.Application.Vehicles.Commands.UpdateVehicleCommandRequestRelated;

internal sealed class UpdateVehicleCommandRequestValidator : AbstractValidator<UpdateVehicleCommandRequest>
{
    public UpdateVehicleCommandRequestValidator()
    {
        GetDescriptionValidationRules();
        GetNumericValueValidationRules();
        GetIdentifierValidationRules();
        GetTypeValidationRules();
        GetLocationValidationRules();
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
        RuleFor(x => x.ColorId)
            .NotEmpty()
            .NotNull()
            .WithMessage(VehicleValidatorMessages.ColorRequired);
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

    private void GetLocationValidationRules()
    {
        RuleFor(x => x.LocationTownId)
            .NotEmpty()
            .WithMessage(VehicleValidatorMessages.TownRequired);
    }
}