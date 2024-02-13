﻿using Domain.Contracts.Common;

namespace Domain.Entities.VehicleRelated.Classes;

public sealed class VehicleDisplacement : IEntity<Guid>
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public double Value { get; set; }
    
    public VehicleDisplacement() { }
    public VehicleDisplacement(double value) => Value = value;
}
