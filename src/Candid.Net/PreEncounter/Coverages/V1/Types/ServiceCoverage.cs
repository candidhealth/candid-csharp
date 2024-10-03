using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record ServiceCoverage
{
    [JsonPropertyName("service_code")]
    public required ServiceTypeCode ServiceCode { get; set; }

    [JsonPropertyName("in_network")]
    public ServiceCoverageDetails? InNetwork { get; set; }

    [JsonPropertyName("in_network_flat")]
    public IEnumerable<CoverageDetails>? InNetworkFlat { get; set; }

    [JsonPropertyName("out_of_network")]
    public ServiceCoverageDetails? OutOfNetwork { get; set; }

    [JsonPropertyName("out_of_network_flat")]
    public IEnumerable<CoverageDetails>? OutOfNetworkFlat { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
