using global::Candid.Net;
using global::Candid.Net.Commons;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Eras;

[Serializable]
public record ProviderLevelAdjustment : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("provider_identifier")]
    public required string ProviderIdentifier { get; set; }

    [JsonPropertyName("adjustment_identifier")]
    public string? AdjustmentIdentifier { get; set; }

    [JsonPropertyName("adjustment_code")]
    public required AdjustmentReasonCode AdjustmentCode { get; set; }

    [JsonPropertyName("adjustment_amount_cents")]
    public required int AdjustmentAmountCents { get; set; }

    /// <summary>
    /// The payee's NPI (835 Loop 1000B N1 with the XX qualifier), when present on the remit.
    /// </summary>
    [JsonPropertyName("payee_npi")]
    public string? PayeeNpi { get; set; }

    /// <summary>
    /// The payee's federal tax identification number (835 Loop 1000B N1 with the FI qualifier, or a REF segment with the TJ qualifier), when present on the remit.
    /// </summary>
    [JsonPropertyName("payee_tin")]
    public string? PayeeTin { get; set; }

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
