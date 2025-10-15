using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.NonInsurancePayers.V1;

[Serializable]
public record GetNonInsurancePayersCategoriesRequest
{
    /// <summary>
    /// Filters categories by fuzzy matching on name.
    /// </summary>
    [JsonIgnore]
    public string? SearchTerm { get; set; }

    /// <summary>
    /// Limits the maximum number of categories that will be returned. Defaults to 100.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    /// <summary>
    /// The page token to continue paging through a previous request.
    /// </summary>
    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
