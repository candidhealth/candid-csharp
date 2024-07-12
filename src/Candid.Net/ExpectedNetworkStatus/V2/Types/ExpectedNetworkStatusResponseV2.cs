using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

public record ExpectedNetworkStatusResponseV2
{
    [JsonPropertyName("network_status_check_id")]
    public required Guid NetworkStatusCheckId { get; init; }

    [JsonPropertyName("network_status")]
    public required object NetworkStatus { get; init; }
}
