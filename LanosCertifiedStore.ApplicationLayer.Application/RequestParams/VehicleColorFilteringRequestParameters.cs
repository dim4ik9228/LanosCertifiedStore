﻿using Application.Contracts.RequestParametersRelated;
using Application.Enums.RequestParametersRelated;
using Application.RequestParams.Common.Classes;
using Domain.Models.VehicleRelated.Classes;

namespace Application.RequestParams;

public sealed class VehicleColorFilteringRequestParameters : BaseFilteringRequestParameters<VehicleColor>,
    IVehicleColorFilteringRequestParameters
{
    public string? Name { get; set; }
    public VehicleColorSelectionProfile SelectionProfile => VehicleColorSelectionProfile.Default;
}