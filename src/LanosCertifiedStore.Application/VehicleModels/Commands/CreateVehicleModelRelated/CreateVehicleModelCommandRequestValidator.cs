using System.Linq.Expressions;
using FluentValidation;

namespace LanosCertifiedStore.Application.VehicleModels.Commands.CreateVehicleModelRelated;

internal sealed class CreateVehicleModelCommandRequestValidator : AbstractValidator<CreateVehicleModelCommandRequest>
{
    public CreateVehicleModelCommandRequestValidator()
    {
        GetNameValidationRules();
        GetBrandValidationRules();
        GetTypeValidationRules();
        GetBodyTypesValidationRules();
        GetTransmissionTypesValidationRules();
        GetDrivetrainTypesValidationRules();
        GetEngineTypesValidationRules();
        GetProductionYearValidationRules();
    }

    private void GetNameValidationRules()
    {
        Expression<Func<CreateVehicleModelCommandRequest, string>> expression = x => x.Name;

        RuleFor(expression)
            .NotEmpty()
            .MinimumLength(2)
            .MaximumLength(64)
            .WithMessage(VehicleModelValidatorMessages.InvalidNameValue);
    }

    private void GetBodyTypesValidationRules()
    {
        Expression<Func<CreateVehicleModelCommandRequest, IEnumerable<Guid>>> expression =
            x => x.AvailableBodyTypesIds;

        RuleFor(expression)
            .NotNull()
            .NotEmpty()
            .WithMessage(VehicleModelValidatorMessages.EmptyBodyTypeCollection);
    }

    private void GetEngineTypesValidationRules()
    {
        Expression<Func<CreateVehicleModelCommandRequest, IEnumerable<Guid>>> expression =
            x => x.AvailableEngineTypesIds;
        
        RuleFor(expression)
            .NotNull()
            .NotEmpty()
            .WithMessage(VehicleModelValidatorMessages.EmptyEngineTypeCollection);
    }

    private void GetDrivetrainTypesValidationRules()
    {
        Expression<Func<CreateVehicleModelCommandRequest, IEnumerable<Guid>>> expression =
            x => x.AvailableDrivetrainTypesIds;

        RuleFor(expression)
            .NotNull()
            .NotEmpty()
            .WithMessage(VehicleModelValidatorMessages.EmptyDrivetrainTypeCollection);
    }

    private void GetTransmissionTypesValidationRules()
    {
        Expression<Func<CreateVehicleModelCommandRequest, IEnumerable<Guid>>> expression =
            x => x.AvailableTransmissionTypesIds;

        RuleFor(expression)
            .NotNull()
            .NotEmpty()
            .WithMessage(VehicleModelValidatorMessages.EmptyTransmissionTypeCollection);
    }

    private void GetBrandValidationRules()
    {
        Expression<Func<CreateVehicleModelCommandRequest, Guid>> expression = x => x.BrandId;

        RuleFor(expression)
            .NotNull()
            .NotEmpty()
            .NotEqual(Guid.Empty)
            .WithMessage(VehicleModelValidatorMessages.InvalidBrandIdValue);
    }

    private void GetTypeValidationRules()
    {
        Expression<Func<CreateVehicleModelCommandRequest, Guid>> expression = x => x.TypeId;

        RuleFor(expression)
            .NotNull()
            .NotEmpty()
            .NotEqual(Guid.Empty)
            .WithMessage(VehicleModelValidatorMessages.InvalidTypeIdValue);
    }

    private void GetProductionYearValidationRules()
    {
        Expression<Func<CreateVehicleModelCommandRequest, int>> minimalProductionYearExpression =
            x => x.MinimalProductionYear;

        Expression<Func<CreateVehicleModelCommandRequest, int>> maximumProductionYearExpression =
            x => x.MaximumProductionYear ?? default;

        RuleFor(minimalProductionYearExpression)
            .GreaterThanOrEqualTo(1900)
            .WithMessage(VehicleModelValidatorMessages.InvalidMinimalProductionYearValue);

        RuleFor(minimalProductionYearExpression)
            .LessThanOrEqualTo(maximumProductionYearExpression)
            .When(p => p.MaximumProductionYear.HasValue)
            .WithMessage(VehicleModelValidatorMessages.TooBigMinimalProductionYearValue);

        RuleFor(maximumProductionYearExpression)
            .GreaterThanOrEqualTo(minimalProductionYearExpression)
            .When(p => p.MaximumProductionYear.HasValue)
            .WithMessage(VehicleModelValidatorMessages.TooSmallMaximumProductionYearValue);
    }
}