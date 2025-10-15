using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PatientAr.V1;

[Serializable]
public record PatientPaymentAllocation : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Payment identifier from the source system (e.g., patient portal, manual entry). Note multiple allocations may exist for a single payment and
    /// thus may share the same source_id.
    /// </summary>
    [JsonPropertyName("source_id")]
    public string? SourceId { get; set; }

    /// <summary>
    /// The amount of the patient payment in cents.
    /// </summary>
    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

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
