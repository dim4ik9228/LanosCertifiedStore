﻿using AutoMapper;
using Domain.Entities.VehicleRelated.Classes;
using Persistence.DataModels;

namespace Persistence.MappingHelpers;

internal sealed class VehicleBrandMappingProfile : Profile
{
    public VehicleBrandMappingProfile()
    {
        AddMappingProfileFromEntityToModel();
        AddMappingProfileFromModelToEntity();
    }

    private void AddMappingProfileFromModelToEntity() =>
        CreateMap<VehicleBrandDataModel, VehicleBrand>();

    private void AddMappingProfileFromEntityToModel() =>
        CreateMap<VehicleBrand, VehicleBrandDataModel>();
}