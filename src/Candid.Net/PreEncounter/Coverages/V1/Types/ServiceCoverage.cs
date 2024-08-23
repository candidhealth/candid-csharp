using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record ServiceCoverage
{
    [JsonPropertyName("service_code")]
    public required ServiceTypeCode ServiceCode { get; set; }

    [JsonPropertyName("in_network")]
    public ServiceCoverageDetails? InNetwork { get; set; }

    [JsonPropertyName("out_of_network")]
    public ServiceCoverageDetails? OutOfNetwork { get; set; }
}
