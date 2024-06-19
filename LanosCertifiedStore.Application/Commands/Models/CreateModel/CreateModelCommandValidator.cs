﻿namespace Application.Commands.Models.CreateModel;

// TODO
// internal sealed class CreateModelCommandValidator : AbstractValidator<CreateModelCommand>
// {
//     public CreateModelCommandValidator(IUnitOfWork unitOfWork, IValidationHelper validationHelper)
//     {
//         RuleFor(x => x.BrandId)
//             .MustAsync(async (brandId, _) => 
//                 await validationHelper.CheckMainAspectPresence<VehicleBrand>(unitOfWork, brandId))
//             .WithMessage("Brand with such ID doesn't exists!");
//
//         RuleFor(x => x.Name)
//             .NotEmpty()
//             .MaximumLength(VehicleModelConstants.MaximumNameLength)
//             .MinimumLength(VehicleModelConstants.MinimalNameLength)
//             .WithMessage("Name must be greater than 2 characters and less than 64!");
//         
//         RuleFor(x => x.Name)
//             .MustAsync(async (name, _) => 
//                 await validationHelper.IsAspectValueUnique<VehicleModel, string>(
//                     unitOfWork,
//                     name,
//                     nameof(VehicleModel.Name)))
//             .WithMessage("Model with such name already exists! Model name must be unique");
//
//         RuleFor(x => x.TypeId)
//             .MustAsync(async (typeId, _) => 
//                 await validationHelper.CheckMainAspectPresence<VehicleType>(unitOfWork, typeId))
//             .WithMessage("Type with such ID doesn't exists!");
//         
//         RuleFor(x => x.AvailableBodyTypeIds)
//             .NotNull()
//             .NotEmpty()
//             .MustAsync(async (ids, _) => 
//                 await validationHelper.CheckMainAspectPresence<VehicleBodyType>(unitOfWork, ids))
//             .WithMessage("Some of the body types don't exist!");
//         
//         RuleFor(x => x.AvailableEngineTypeIds)
//             .NotNull()
//             .NotEmpty()
//             .MustAsync(async (ids, _) => 
//                 await validationHelper.CheckMainAspectPresence<VehicleEngineType>(unitOfWork, ids))
//             .WithMessage("Some of the engine types don't exist!");
//         
//         RuleFor(x => x.AvailableTransmissionTypeIds)
//             .NotNull()
//             .NotEmpty()
//             .MustAsync(async (ids, _) => 
//                 await validationHelper.CheckMainAspectPresence<VehicleTransmissionType>(unitOfWork, ids))
//             .WithMessage("Some of the transmission types don't exist!");
//         
//         RuleFor(x => x.AvailableDrivetrainTypeIds)
//             .NotNull()
//             .NotEmpty()
//             .MustAsync(async (ids, _) => 
//                 await validationHelper.CheckMainAspectPresence<VehicleDrivetrainType>(unitOfWork, ids))
//             .WithMessage("Some of the drivetrain types don't exist!");
//         
//         RuleFor(x => x.MinimalProductionYear)
//             .LessThanOrEqualTo(x => x.MaximumProductionYear)
//             .When(x => x.MaximumProductionYear is not null)
//             .WithMessage("Minimal production year must be less or equal to the maximum production year!");
//         
//         RuleFor(x => x.MaximumProductionYear)
//             .GreaterThanOrEqualTo(x => x.MinimalProductionYear)
//             .When(x => x.MaximumProductionYear is not null)
//             .WithMessage("Maximum production year must be greater or equal to the minimal production year!");
//     }
// }