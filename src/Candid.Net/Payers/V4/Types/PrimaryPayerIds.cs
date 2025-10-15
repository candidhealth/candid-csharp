using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Payers.V4;

[Serializable]
public record PrimaryPayerIds : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
