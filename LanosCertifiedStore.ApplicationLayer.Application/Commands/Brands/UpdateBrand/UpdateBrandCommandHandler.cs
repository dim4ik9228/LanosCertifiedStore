﻿using Application.Commands.Common;
using Domain.Contracts.RepositoryRelated;
using Domain.Entities.VehicleRelated.Classes;
using Domain.Shared;
using MediatR;

namespace Application.Commands.Brands.UpdateBrand;

internal sealed class UpdateBrandCommandHandler : CommandBase<Unit>, IRequestHandler<UpdateBrandCommand, Result<Unit>>
{
    private readonly IUnitOfWork _unitOfWork;

    public UpdateBrandCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
        _unitOfWork = unitOfWork;
        PossibleErrorMessages = 
            ["Saving an updated brand was not successful!", "Error occured during the brand update!"];
        PossibleErrorCode = "UpdateBrandError";
    }
    
    public async Task<Result<Unit>> Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
    {
        var brandRepository = _unitOfWork.RetrieveRepository<VehicleBrand>();
        var updatedBrand = await brandRepository.GetEntityByIdAsync(request.Id);

        if (updatedBrand is null) return Result<Unit>.Failure(Error.NotFound);

        UpdateBrand(request.UpdatedName, updatedBrand, brandRepository);

        return await TrySaveChanges(cancellationToken);
    }

    private void UpdateBrand(string updatedName, VehicleBrand brand, IRepository<VehicleBrand> repository)
    {
        brand.Name = updatedName;

        repository.UpdateExistingEntity(brand);
    }
}