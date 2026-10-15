using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.ExternalConsolidatedRemit.V1;

[Serializable]
public record PaymentBundle : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("era_payment_id")]
    public required string EraPaymentId { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonPropertyName("allocation_method")]
    public required PaymentBundleAllocationMethod AllocationMethod { get; set; }

    /// <summary>
    /// Set once the bundle has been allocated to a specific service line.
    /// </summary>
    [JsonPropertyName("service_line_id")]
    public string? ServiceLineId { get; set; }

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
