using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.ExternalConsolidatedRemit.V1;

/// <summary>
/// Provider-level (PLB) money that isn't tied to a single claim. Bundles start out unallocated
/// to any claim, and once allocated are tied only to a service line - not to an individual claim
/// payment.
/// </summary>
[Serializable]
public record TransactionSourcePaymentBundle : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("payment_bundle")]
    public required PaymentBundle PaymentBundle { get; set; }

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
