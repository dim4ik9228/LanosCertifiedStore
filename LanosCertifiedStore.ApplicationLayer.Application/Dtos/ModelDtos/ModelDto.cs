﻿using Application.Dtos.Common;

namespace Application.Dtos.ModelDtos;

public sealed class ModelDto : VehicleAspectDto
{
    public string VehicleBrand { get; set; }
}