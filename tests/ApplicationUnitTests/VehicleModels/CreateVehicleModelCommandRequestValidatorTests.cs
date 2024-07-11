﻿using System.Linq.Expressions;
using Application.Shared.ValidationRelated;
using Application.VehicleModels;
using Application.VehicleModels.Commands.CreateVehicleModelRelated;
using Domain.Entities.VehicleRelated;
using Domain.Entities.VehicleRelated.TypeRelated;
using FluentValidation.TestHelper;

namespace ApplicationUnitTests.VehicleModels;

public sealed class CreateVehicleModelCommandRequestValidatorTests
{
    private readonly IValidationHelper _validationHelper = Substitute.For<IValidationHelper>();
    private readonly CreateVehicleModelCommandRequestValidator _validator;

    public CreateVehicleModelCommandRequestValidatorTests()
    {
        _validator = new CreateVehicleModelCommandRequestValidator(_validationHelper);
    }

    [Fact]
    public async Task Should_HaveError_WhenNameIsEmpty()
    {
        // Arrange
        var model = VehicleModelTestExemplars.WithEmptyName();

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Name);
    }

    [Fact]
    public async Task Should_HaveError_WhenNameIsTooShort()
    {
        // Arrange
        var model = VehicleModelTestExemplars.WithTooShortName();

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Name);
    }

    [Fact]
    public async Task Should_HaveError_WhenNameIsTooLong()
    {
        // Arrange
        var model = VehicleModelTestExemplars.WithTooLongName();

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Name);
    }

    [Fact]
    public async Task Should_HaveError_WhenNameIsNotUnique()
    {
        // Arrange
        var model = VehicleModelTestExemplars.Regular();

        _validationHelper
            .CheckAspectValueUniqueness(Arg.Any<string>(), Arg.Any<Expression<Func<VehicleModel, bool>>>())
            .Returns(false);

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Name)
            .WithErrorMessage(VehicleModelValidatorMessages.AlreadyExistingNameValue);
    }

    [Fact]
    public async Task Should_HaveError_WhenAnyOfTransmissionTypesDoesNotExist()
    {
        // Arrange
        var model = VehicleModelTestExemplars.Regular();

        _validationHelper
            .CheckMainAspectPresence<VehicleTransmissionType>(Arg.Any<IEnumerable<Guid>>())
            .Returns((Guid.NewGuid(), false));

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.AvailableTransmissionTypesIds);
    }

    [Fact]
    public async Task Should_HaveError_WhenAnyOfBodyTypesDoesNotExist()
    {
        // Arrange
        var model = VehicleModelTestExemplars.Regular();

        _validationHelper
            .CheckMainAspectPresence<VehicleBodyType>(Arg.Any<IEnumerable<Guid>>())
            .Returns((Guid.NewGuid(), false));

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.AvailableBodyTypesIds);
    }

    [Fact]
    public async Task Should_HaveError_WhenAnyOfDrivetrainTypesDoesNotExist()
    {
        // Arrange
        var model = VehicleModelTestExemplars.Regular();

        _validationHelper
            .CheckMainAspectPresence<VehicleDrivetrainType>(Arg.Any<IEnumerable<Guid>>())
            .Returns((Guid.NewGuid(), false));

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.AvailableDrivetrainTypesIds);
    }

    [Fact]
    public async Task Should_HaveError_WhenAnyOfEngineTypesDoesNotExist()
    {
        // Arrange
        var model = VehicleModelTestExemplars.Regular();

        _validationHelper
            .CheckMainAspectPresence<VehicleEngineType>(Arg.Any<IEnumerable<Guid>>())
            .Returns((Guid.NewGuid(), false));

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.AvailableEngineTypesIds);
    }

    [Fact]
    public async Task Should_HaveError_BrandDoesNotExist()
    {
        // Arrange
        var model = VehicleModelTestExemplars.Regular();

        _validationHelper
            .CheckMainAspectPresence<VehicleBrand>(Arg.Any<Guid>())
            .Returns(false);

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.BrandId);
    }

    [Fact]
    public async Task Should_HaveError_TypeDoesNotExist()
    {
        // Arrange
        var model = VehicleModelTestExemplars.Regular();

        _validationHelper
            .CheckMainAspectPresence<VehicleType>(Arg.Any<Guid>())
            .Returns(false);

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.TypeId);
    }

    [Theory]
    [InlineData(2000, 1998)]
    [InlineData(1899, 1998)]
    public async Task Should_HaveError_WhenMinimalProductionYearIsInvalid(
        int minimalProductionYear,
        int maximumProductionYear)
    {
        var model = VehicleModelTestExemplars.WithProductionYears(minimalProductionYear, maximumProductionYear);

        var result = await _validator.TestValidateAsync(model);

        result.ShouldHaveValidationErrorFor(m => m.MinimalProductionYear);
    }
}