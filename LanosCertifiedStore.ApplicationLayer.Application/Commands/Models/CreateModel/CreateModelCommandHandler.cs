﻿using Application.Commands.Common;
using Application.Contracts.RepositoryRelated.Common;
using Application.Shared;
using Domain.Models.VehicleRelated.Classes;
using Domain.Models.VehicleRelated.Classes.TypeRelated;
using MediatR;

namespace Application.Commands.Models.CreateModel;

// TODO
// internal sealed class CreateModelCommandHandler : 
//     CommandHandlerBase<Unit>, IRequestHandler<CreateModelCommand, Result<Unit>>
// {
//     public CreateModelCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
//     {
//         PossibleErrors =
//         [
//             new Error("CreateModelError", "Saving a new model was not successful!"),
//             new Error("CreateModelError", "Error occured during a new model creation!")
//         ];
//     }
//
//     public async Task<Result<Unit>> Handle(CreateModelCommand request, CancellationToken cancellationToken)
//     {
//         var vehicleBrand = await GetRequiredRepository<VehicleBrand>().GetEntityByIdAsync(request.BrandId);
//         var vehicleType = await GetRequiredRepository<VehicleType>().GetEntityByIdAsync(request.TypeId);
//
//         var newVehicleModel = new VehicleModel(
//             vehicleBrand!,
//             vehicleType!,
//             request.Name,
//             request.AvailableEngineTypeIds,
//             request.AvailableTransmissionTypeIds,
//             request.AvailableDrivetrainTypeIds,
//             request.AvailableBodyTypeIds,
//             request.MinimalProductionYear,
//             request.MaximumProductionYear);
//         
//         await GetRequiredRepository<VehicleModel>().AddNewEntityAsync(newVehicleModel);
//         
//         return await TrySaveChanges(cancellationToken);
//     }
// }