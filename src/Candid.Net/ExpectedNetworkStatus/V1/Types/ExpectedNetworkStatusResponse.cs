using System.Text.Json.Serialization;
using Candid.Net.ExpectedNetworkStatus.V1;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V1;

public record ExpectedNetworkStatusResponse
{
    /// <summary>
    /// The anticipated classification of a healthcare provider within the insurance plan's network.
    /// </summary>
    [JsonPropertyName("expected_network_status")]
    public required ExpectedNetworkStatus ExpectedNetworkStatus { get; set; }

    [JsonPropertyName("explanation")]
    public required string Explanation { get; set; }

    [JsonPropertyName("contract_id")]
    public string? ContractId { get; set; }
}
