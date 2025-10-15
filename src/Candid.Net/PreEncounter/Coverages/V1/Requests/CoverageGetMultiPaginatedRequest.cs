using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Coverages.V1;

[Serializable]
public record CoverageGetMultiPaginatedRequest
{
    [JsonIgnore]
    public string? PatientId { get; set; }

    [JsonIgnore]
    public string? PayerPlanGroupId { get; set; }

    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <summary>
    /// Must be between 0 and 1000. Defaults to 100
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
