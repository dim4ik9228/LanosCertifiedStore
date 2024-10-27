using System.Linq.Expressions;
using FluentValidation;

namespace LanosCertifiedStore.Application.VehicleModels.Commands.UpdateVehicleModelRelated;

internal sealed class UpdateVehicleModelCommandRequestValidator : AbstractValidator<UpdateVehicleModelCommandRequest>
{
    public UpdateVehicleModelCommandRequestValidator()
    {
        GetBodyTypesValidationRules();
        GetTransmissionTypesValidationRules();
        GetDrivetrainTypesValidationRules();
        GetEngineTypesValidationRules();
    }
    
    private void GetBodyTypesValidationRules()
    {
        Expression<Func<UpdateVehicleModelCommandRequest, IEnumerable<Guid>>> expression =
            x => x.AvailableBodyTypesIds;

        RuleFor(expression)
            .NotNull()
            .NotEmpty()
            .WithMessage(VehicleModelValidatorMessages.EmptyBodyTypeCollection);
    }

    private void GetEngineTypesValidationRules()
    {
        Expression<Func<UpdateVehicleModelCommandRequest, IEnumerable<Guid>>> expression =
            x => x.AvailableEngineTypesIds;
        
        RuleFor(expression)
            .NotNull()
            .NotEmpty()
            .WithMessage(VehicleModelValidatorMessages.EmptyEngineTypeCollection);
    }

    private void GetDrivetrainTypesValidationRules()
    {
        Expression<Func<UpdateVehicleModelCommandRequest, IEnumerable<Guid>>> expression =
            x => x.AvailableDrivetrainTypesIds;

        RuleFor(expression)
            .NotNull()
            .NotEmpty()
            .WithMessage(VehicleModelValidatorMessages.EmptyDrivetrainTypeCollection);
    }

    private void GetTransmissionTypesValidationRules()
    {
        Expression<Func<UpdateVehicleModelCommandRequest, IEnumerable<Guid>>> expression =
            x => x.AvailableTransmissionTypesIds;

        RuleFor(expression)
            .NotNull()
            .NotEmpty()
            .WithMessage(VehicleModelValidatorMessages.EmptyTransmissionTypeCollection);
    }
}