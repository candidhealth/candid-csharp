using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Payers.V4;

public record PayerIds
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
    public required string EligibilityPayerId { get; set; }

    /// <summary>
    /// The payer ID for remittance
    /// </summary>
    [JsonPropertyName("remittance_payer_id")]
    public required string RemittancePayerId { get; set; }

    /// <summary>
    /// The support state for claims submission
    /// </summary>
    [JsonPropertyName("claims_support")]
    public required SupportState ClaimsSupport { get; set; }

    /// <summary>
    /// The support state for eligibility
    /// </summary>
    [JsonPropertyName("eligibility_support")]
    public required SupportState EligibilitySupport { get; set; }

    /// <summary>
    /// The support state for remittance
    /// </summary>
    [JsonPropertyName("remittance_support")]
    public required SupportState RemittanceSupport { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
