﻿using Application.Dtos.PriceDtos;
using AutoMapper;
using Domain.Models.VehicleRelated.Classes;

namespace Application.MappingProfiles;

public sealed class VehiclePriceRelatedMappingProfile : Profile
{
    public VehiclePriceRelatedMappingProfile()
    {
        CreateMap<VehiclePrice, PriceDto>();
    }
}