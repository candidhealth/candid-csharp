using Candid.Net.Core;

#nullable enable

namespace Candid.Net.NonInsurancePayers.V1;

public record GetNonInsurancePayersCategoriesRequest
{
    /// <summary>
    /// Filters categories by fuzzy matching on name.
    /// </summary>
    public string? SearchTerm { get; set; }

    /// <summary>
    /// Limits the maximum number of categories that will be returned. Defaults to 100.
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// The page token to continue paging through a previous request.
    /// </summary>
    public string? PageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
