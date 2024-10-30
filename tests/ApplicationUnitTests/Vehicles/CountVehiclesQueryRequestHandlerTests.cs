using LanosCertifiedStore.Application.Shared.DtosRelated;
using LanosCertifiedStore.Application.Vehicles;
using LanosCertifiedStore.Application.Vehicles.Queries.CountVehiclesQueryRelated;

namespace ApplicationUnitTests.Vehicles;

public sealed class CountVehiclesQueryRequestHandlerTests
{
    private readonly IVehicleService _vehicleService = Substitute.For<IVehicleService>();
    private readonly CountVehiclesQueryRequestHandler _handler;
    private readonly CountVehiclesQueryRequest _request;

    public CountVehiclesQueryRequestHandlerTests()
    {
        _handler = new CountVehiclesQueryRequestHandler(_vehicleService);
        _request = new CountVehiclesQueryRequest(new VehicleFilteringRequestParameters());
    }

    [Fact]
    public async Task Handle_ShouldCallVehicleServiceWithCorrectRequest()
    {
        // Arrange
        var expectedCount = new ItemsCountDto(10, 5);
        _vehicleService
            .GetVehiclesCount(Arg.Any<CountVehiclesQueryRequest>(), Arg.Any<CancellationToken>())
            .Returns(expectedCount);

        // Act
        await _handler.Handle(_request, default);

        // Assert
        await _vehicleService
            .Received(1)
            .GetVehiclesCount(
                Arg.Is<CountVehiclesQueryRequest>(r => r == _request),
                Arg.Any<CancellationToken>());
    }

    [Fact]
    public async Task Handle_ShouldReturnCorrectCountFromService()
    {
        // Arrange
        var expectedCount = new ItemsCountDto(10, 5);
        _vehicleService
            .GetVehiclesCount(Arg.Any<CountVehiclesQueryRequest>(), Arg.Any<CancellationToken>())
            .Returns(expectedCount);

        // Act
        var result = await _handler.Handle(_request, default);

        // Assert
        result.IsSuccess.Should().BeTrue();
        result.Value.Should().NotBeNull();
        result.Value.TotalItemsCount.Should().Be(expectedCount.TotalItemsCount);
        result.Value.FilteredItemsCount.Should().Be(expectedCount.FilteredItemsCount);
    }
    
    [Theory]
    [InlineData(0, 0)]
    [InlineData(100, 50)]
    [InlineData(1000, 1000)]
    public async Task Handle_WithDifferentCounts_ShouldReturnCorrectValues(
        int totalCount,
        int filteredCount)
    {
        // Arrange
        var expectedCount = new ItemsCountDto(totalCount, filteredCount);
        _vehicleService
            .GetVehiclesCount(Arg.Any<CountVehiclesQueryRequest>(), Arg.Any<CancellationToken>())
            .Returns(expectedCount);

        // Act
        var result = await _handler.Handle(_request, default);

        // Assert
        result.IsSuccess.Should().BeTrue();
        result.Value.Should().NotBeNull();
        result.Value.TotalItemsCount.Should().Be(totalCount);
        result.Value.FilteredItemsCount.Should().Be(filteredCount);
    }
}