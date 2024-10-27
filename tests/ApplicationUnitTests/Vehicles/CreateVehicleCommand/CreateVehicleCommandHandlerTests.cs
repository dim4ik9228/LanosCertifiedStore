using LanosCertifiedStore.Application.Identity;
using LanosCertifiedStore.Application.Vehicles;
using LanosCertifiedStore.Application.Vehicles.Commands.CreateVehicleCommandRequestRelated;
using LanosCertifiedStore.Domain.Entities.VehicleRelated;

namespace ApplicationUnitTests.Vehicles.CreateVehicleCommand;

public sealed class CreateVehicleCommandHandlerTests
{
    private readonly IVehicleService _vehicleService = Substitute.For<IVehicleService>();
    private readonly IUserContext _userContext = Substitute.For<IUserContext>();
    private readonly CreateVehicleCommandRequestHandler _requestHandler;
    private readonly CreateVehicleCommandRequest _request = CreateVehicleCommandTestExemplars.Regular();

    public CreateVehicleCommandHandlerTests()
    {
        _requestHandler = new CreateVehicleCommandRequestHandler(_vehicleService, _userContext);
    }

    [Fact]
    public async Task Handler_ShouldInvokeAddNewVehicle_FromVehicleService()
    {
        // Arrange & Act
        await _requestHandler.Handle(_request, default);

        // Assert
        await _vehicleService
            .Received()
            .AddAsync(Arg.Any<Vehicle>());
    }

    [Fact]
    public async Task Handler_ShouldNotThrowIfResponseIsSuccessful()
    {
        // Arrange
        _vehicleService.AddAsync(Arg.Any<Vehicle>()).Returns(Task.CompletedTask);

        // Act
        var result = await _requestHandler.Handle(_request, default);

        // Assert
        result.IsSuccess
            .Should().BeTrue();
    }
}