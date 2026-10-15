using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.ExternalConsolidatedRemit.V1;

[Serializable]
public record ExternalConsolidatedRemitEraPaymentsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("consolidated_remit_id")]
    public required string ConsolidatedRemitId { get; set; }

    [JsonPropertyName("era_payments")]
    public IEnumerable<ExternalConsolidatedRemitEraPayment> EraPayments { get; set; } =
        new List<ExternalConsolidatedRemitEraPayment>();

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
