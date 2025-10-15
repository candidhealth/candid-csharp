using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.ExpectedNetworkStatus.V2;

[Serializable]
public record IndeterminateNetworkStatus : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("error")]
    public required string Error { get; set; }

    [JsonPropertyName("explanation")]
    public required Explanation Explanation { get; set; }

    [JsonPropertyName("routed_payer_uuid")]
    public string? RoutedPayerUuid { get; set; }

    [JsonPropertyName("routed_billing_provider_id")]
    public string? RoutedBillingProviderId { get; set; }

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
