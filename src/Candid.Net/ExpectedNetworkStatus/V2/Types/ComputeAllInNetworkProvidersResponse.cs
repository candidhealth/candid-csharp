using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

public record ComputeAllInNetworkProvidersResponse
{
    [JsonPropertyName("computed_network_status")]
    public required object ComputedNetworkStatus { get; set; }

    /// <summary>
    /// Unique network status check ID for this request
    /// </summary>
    [JsonPropertyName("network_status_check_id")]
    public required string NetworkStatusCheckId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
