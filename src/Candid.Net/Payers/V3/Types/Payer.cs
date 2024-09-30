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

    /// <summary>
    /// The name of the payer as it appears in Availity.
    /// </summary>
    [JsonPropertyName("availity_payer_name")]
    public string? AvailityPayerName { get; set; }

    /// <summary>
    /// The ID of the payer as it appears in Availity.
    /// </summary>
    [JsonPropertyName("availity_claims_payer_id")]
    public string? AvailityClaimsPayerId { get; set; }

    /// <summary>
    /// The eligibility ID of the payer as it appears in Availity.
    /// </summary>
    [JsonPropertyName("availity_eligibility_id")]
    public string? AvailityEligibilityId { get; set; }

    /// <summary>
    /// The remittance ID of the payer as it appears in Availity.
    /// </summary>
    [JsonPropertyName("availity_remittance_payer_id")]
    public string? AvailityRemittancePayerId { get; set; }
}
