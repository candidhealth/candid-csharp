using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Payers.V3;

public record PayerInfo
{
    [JsonPropertyName("payer_id")]
    public required string PayerId { get; set; }

    [JsonPropertyName("payer_name")]
    public required string PayerName { get; set; }
}
