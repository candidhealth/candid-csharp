using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record CoverageBenefits
{
    [JsonPropertyName("plan_coverage")]
    public PlanCoverage? PlanCoverage { get; set; }

    [JsonPropertyName("service_specific_coverage")]
    public IEnumerable<ServiceCoverage>? ServiceSpecificCoverage { get; set; }
}