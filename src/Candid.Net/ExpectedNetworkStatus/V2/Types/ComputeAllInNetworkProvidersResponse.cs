using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

public record ComputeAllInNetworkProvidersResponse
{
    [JsonPropertyName("computed_network_status")]
    public required object ComputedNetworkStatus { get; init; }

    /// <summary>
    /// Unique network status check ID for this request
    /// </summary>
    [JsonPropertyName("network_status_check_id")]
    public required string NetworkStatusCheckId { get; init; }
}
