using LanosCertifiedStore.Domain.Contracts.Common;

namespace LanosCertifiedStore.Application.Shared.RequestParamsRelated;

public abstract class BaseFilteringRequestParameters<TModel> : IFilteringRequestParameters<TModel> 
    where TModel : IIdentifiable<Guid>
{
    private const int InitialPageIndex = 1;
    private int _pageIndex = InitialPageIndex;
    
    public int PageIndex
    {
        get => _pageIndex;
        init => _pageIndex = value < InitialPageIndex 
            ? InitialPageIndex 
            : value;
    }

    public ItemQuantitySelection ItemQuantity
    {
        get => MaxQuantityPerRequest;
        init => MaxQuantityPerRequest = (int)value < (int)MaxQuantityPerRequest ? value : MaxQuantityPerRequest;
    }

    protected ItemQuantitySelection MaxQuantityPerRequest { get; private set; } = ItemQuantitySelection.Hundred;

    public string? SortingType { get; set; }
}