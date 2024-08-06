using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Payers.V3;

public record Payer
{
    /// <summary>
    /// Auto-generated ID set on creation.
    /// </summary>
    [JsonPropertyName("payer_uuid")]
    public required string PayerUuid { get; set; }

    /// <summary>
    /// The primary national payer ID of the payer.
    /// </summary>
    [JsonPropertyName("payer_id")]
    public required string PayerId { get; set; }

    /// <summary>
    /// The primary display name of the payer.
    /// </summary>
    [JsonPropertyName("payer_name")]
    public required string PayerName { get; set; }
}
