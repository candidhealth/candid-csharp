using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Payers.V4;

public record PrimaryPayerIds
{
    /// <summary>
    /// The payer ID for claim submission
    /// </summary>
    [JsonPropertyName("claims_payer_id")]
    public required string ClaimsPayerId { get; set; }

    /// <summary>
    /// The payer ID for eligibility
    /// </summary>
    [JsonPropertyName("eligibility_payer_id")]
    public string? EligibilityPayerId { get; set; }

    /// <summary>
    /// The payer ID for remittance
    /// </summary>
    [JsonPropertyName("remittance_payer_id")]
    public string? RemittancePayerId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
