﻿using Application.Commands.Brands.Shared.ValidatorRelated;
using Application.Contracts.RepositoryRelated.Common;
using Application.Helpers.ValidationRelated.Common.Contracts;

namespace Application.Commands.Brands.UpdateBrand;

// TODO
// internal sealed class UpdateBrandCommandValidator : BrandValidatorBase<UpdateBrandCommand>
// {
//     public UpdateBrandCommandValidator(
//         IUnitOfWork unitOfWork,
//         IValidationHelper validationHelper) : base(unitOfWork, validationHelper)
//     {
//         GetNameLengthValidationRule(x => x.UpdatedName);
//         GetNameUniquenessValidationRule(x => x.UpdatedName);
//     }
// }