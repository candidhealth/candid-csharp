using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Payers.V4;

[Serializable]
public record ClearinghousePayerInfo : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The clearinghouse display name of the payer.
    /// </summary>
    [JsonPropertyName("payer_name")]
    public required string PayerName { get; set; }

    /// <summary>
    /// Payer IDs for professional claims
    /// </summary>
    [JsonPropertyName("professional_payer_ids")]
    public required PayerIds ProfessionalPayerIds { get; set; }

    /// <summary>
    /// Payer IDs for institutional claims
    /// </summary>
    [JsonPropertyName("institutional_payer_ids")]
    public required PayerIds InstitutionalPayerIds { get; set; }

    /// <summary>
    /// The support state for claims submission
    /// </summary>
    [JsonPropertyName("professional_claims_support")]
    public required SupportState ProfessionalClaimsSupport { get; set; }

    /// <summary>
    /// The support state for institutional claims submission
    /// </summary>
    [JsonPropertyName("institutional_claims_support")]
    public required SupportState InstitutionalClaimsSupport { get; set; }

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
