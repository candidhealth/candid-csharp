using global::Candid.Net;
using global::Candid.Net.Core;
using global::Candid.Net.Eras;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.ExternalConsolidatedRemit.V1;

[Serializable]
public record TransactionSourceEraServicePayment : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("era_service_payment")]
    public required EraServicePayment EraServicePayment { get; set; }

    /// <summary>
    /// The matched service line, if any (null if unmatched).
    /// </summary>
    [JsonPropertyName("service_line_id")]
    public string? ServiceLineId { get; set; }

    [JsonPropertyName("era_claim_payment")]
    public required EraClaimPaymentSummary EraClaimPayment { get; set; }

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
