using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record CoverageGetMultiPaginatedRequest
{
    public string? PatientId { get; set; }

    public string? PayerPlanGroupId { get; set; }

    public string? PageToken { get; set; }

    /// <summary>
    /// Must be between 0 and 1000. Defaults to 100
    /// </summary>
    public int? Limit { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
