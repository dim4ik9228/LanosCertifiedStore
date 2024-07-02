﻿using Application.Contracts.RepositoryRelated.Common;
using Application.Enums.RequestParametersRelated.TypeRelated;
using Domain.Entities.VehicleRelated.TypeRelated;

namespace Application.Contracts.RequestParametersRelated.TypeRelated;

public interface IVehicleEngineTypeFilteringRequestParameters : IFilteringRequestParameters<VehicleEngineType>
{
    string? Name { get; set; }
    VehicleEngineTypeSelectionProfile SelectionProfile { get; }
}