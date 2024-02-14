﻿using Application.Core;
using Domain.Contracts.RepositoryRelated;
using Domain.Entities.VehicleRelated.Classes;
using MediatR;

namespace Application.Commands.Types.UpdateType;

internal sealed class UpdateTypeCommandHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<UpdateTypeCommand, Result<Unit>>
{
    public async Task<Result<Unit>> Handle(UpdateTypeCommand request, CancellationToken cancellationToken)
    {
        var existingType = await unitOfWork.RetrieveRepository<VehicleType>().GetEntityByIdAsync(request.UpdateTypeDto.Id);

        if (existingType is null) 
            return Result<Unit>.Failure("Such type doesn't exists!");
        
        existingType.Name = request.UpdateTypeDto.UpdatedName;
        
        unitOfWork.RetrieveRepository<VehicleType>().UpdateExistingEntity(existingType);

        var result = await unitOfWork.SaveChangesAsync(cancellationToken) > 0;

        return result ? Result<Unit>.Success(Unit.Value) : Result<Unit>.Failure("Failed to update type!");
    }
}