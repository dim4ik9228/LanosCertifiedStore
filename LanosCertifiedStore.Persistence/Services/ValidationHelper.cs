﻿using Application.Contracts.ValidationRelated;
using Domain.Contracts.Common;
using Persistence.Contexts.ApplicationDatabaseContext;

namespace Persistence.Services;

internal sealed class ValidationHelper(
    ApplicationDatabaseContext context) : IValidationHelper
{
    public async Task<bool> CheckAspectValueUniqueness<TMainAspect, TValue>(
        TValue value,
        string aspectName) 
        where TMainAspect : class, IIdentifiable<Guid>
    {
        throw new NotImplementedException();
        // var items = await unitOfWork.RetrieveRepository<TMainAspect>().GetAllEntitiesAsync();
        //
        // var nameProperty = typeof(TMainAspect).GetProperty(aspectName)!;
        //
        // return !items.All(x => ((TValue)nameProperty.GetValue(x)!).Equals(value));
    }

    public async Task<bool> CheckMainAspectPresence<TMainAspect>(Guid id)
        where TMainAspect : class, IIdentifiable<Guid>
    {
        throw new NotImplementedException();
        // var mainAspect = await unitOfWork.RetrieveRepository<TMainAspect>().GetEntityByIdAsync(id);
        //
        // return mainAspect is not null;
    }
    
    public async Task<bool> CheckMainAspectPresence<TMainAspect>(IEnumerable<Guid> ids)
        where TMainAspect : class, IIdentifiable<Guid>
    {
        // foreach (var id in ids)
        // {
        //     var mainAspect = await unitOfWork.RetrieveRepository<TMainAspect>().GetEntityByIdAsync(id);
        //
        //     if (mainAspect is null) return false;
        // }
        //
        // return true;
        throw new NotImplementedException();
    }
    
    public async Task<bool> CheckSecondaryAspectPresence<TMainAspect, TSecondaryAspect>(
        (Guid?, Guid?)? ids,
        Func<TMainAspect, Guid> mainAspectIdSelector)
        where TMainAspect : class, IIdentifiable<Guid>
        where TSecondaryAspect : class, IIdentifiable<Guid>
    {
        // if (!IsValidInputData(ids, out var mainAspectId, out var secondaryAspectId)) 
        //     return false;
        //
        // var mainAspect = await unitOfWork.RetrieveRepository<TMainAspect>().GetEntityByIdAsync(
        //     mainAspectId!.Value);
        // var secondaryAspect = await unitOfWork.RetrieveRepository<TSecondaryAspect>().GetEntityByIdAsync(
        //     secondaryAspectId!.Value);
        //
        // if (!AreExistingItems(mainAspect, secondaryAspect)) return false;
        //
        // var selectedId = mainAspectIdSelector(mainAspect!);
        //
        // return selectedId.Equals(secondaryAspectId);
        throw new NotImplementedException();
    }

    public async Task<bool> CheckSecondaryAspectPresence<TMainAspect, TSecondaryAspect>(
        (Guid?, Guid?)? ids,
        Func<TMainAspect, IEnumerable<Guid>> mainAspectIdsSelector)
        where TMainAspect : class, IIdentifiable<Guid>
        where TSecondaryAspect : class, IIdentifiable<Guid>
    {
        // if (!IsValidInputData(ids, out var mainAspectId, out var secondaryAspectId)) 
        //     return false;
        //
        // var mainAspect = await unitOfWork.RetrieveRepository<TMainAspect>().GetEntityByIdAsync(
        //     mainAspectId!.Value);
        // var secondaryAspect = await unitOfWork.RetrieveRepository<TSecondaryAspect>().GetEntityByIdAsync(
        //     secondaryAspectId!.Value);
        //
        // if (!AreExistingItems(mainAspect, secondaryAspect)) return false;
        //
        // var selectedIds = mainAspectIdsSelector(mainAspect!);
        //
        // return selectedIds.Contains(secondaryAspectId.Value);
        throw new NotImplementedException();
    }

    private bool AreExistingItems<TMainAspect, TSecondaryAspect>(
        TMainAspect? mainAspect, TSecondaryAspect? secondaryAspect)
        where TMainAspect : class, IIdentifiable<Guid> 
        where TSecondaryAspect : class, IIdentifiable<Guid>
    {
        if (mainAspect is null) return false;
        
        return secondaryAspect is not null;
    }

    private bool IsValidInputData((Guid?, Guid?)? ids, out Guid? mainAspectId, out Guid? secondaryAspectId)
    {
        if (ids is null)
        {
            mainAspectId = null;
            secondaryAspectId = null;
            return false;
        }

        mainAspectId = ids.Value.Item1;
        secondaryAspectId = ids.Value.Item2;
        
        if (IsInvalidAspectId(mainAspectId)) return false;
        
        return !IsInvalidAspectId(secondaryAspectId);
    }

    private bool IsInvalidAspectId(Guid? id) => id is null || id.Value.Equals(Guid.Empty);
}