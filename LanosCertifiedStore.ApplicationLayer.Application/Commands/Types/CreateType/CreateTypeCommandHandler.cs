﻿using Application.Commands.Common;
using Domain.Contracts.RepositoryRelated.Common;
using Domain.Entities.VehicleRelated.Classes.TypesRelated;
using Domain.Shared;
using MediatR;

namespace Application.Commands.Types.CreateType;

internal sealed class CreateTypeCommandHandler 
    : CommandHandlerBase<Unit>, IRequestHandler<CreateTypeCommand, Result<Unit>>
{
    public CreateTypeCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
        PossibleErrors = new[]
        {
            new Error("CreateTypeError", "Saving a new type was not successful!"),
            new Error("CreateTypeError", "Error occured during a new type creation!")
        };
    }

    public async Task<Result<Unit>> Handle(CreateTypeCommand request, CancellationToken cancellationToken)
    {
        var newVehicleType = new VehicleType(request.Name);

        await GetRequiredRepository<VehicleType>().AddNewEntityAsync(newVehicleType);

        return await TrySaveChanges(cancellationToken);
    }
}