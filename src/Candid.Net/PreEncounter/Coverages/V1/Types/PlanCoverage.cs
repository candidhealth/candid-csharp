using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record PlanCoverage
{
    [JsonPropertyName("in_network")]
    public PlanCoverageDetails? InNetwork { get; set; }

    [JsonPropertyName("out_of_network")]
    public PlanCoverageDetails? OutOfNetwork { get; set; }
}
