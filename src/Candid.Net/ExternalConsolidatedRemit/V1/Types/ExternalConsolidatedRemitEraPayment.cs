using global::Candid.Net;
using global::Candid.Net.Core;
using global::Candid.Net.Eras;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.ExternalConsolidatedRemit.V1;

[Serializable]
public record ExternalConsolidatedRemitEraPayment : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Includes the nested era_document with source/status/storage details.
    /// </summary>
    [JsonPropertyName("era_payment")]
    public required EraPayment EraPayment { get; set; }

    /// <summary>
    /// True for the ERA payment currently elected as this consolidated remit's primary remit.
    /// </summary>
    [JsonPropertyName("is_primary")]
    public required bool IsPrimary { get; set; }

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
