using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

public record ExpectedNetworkStatusResponseV2
{
    [JsonPropertyName("network_status_check_id")]
    public required string NetworkStatusCheckId { get; set; }

    [JsonPropertyName("network_status")]
    public required object NetworkStatus { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
