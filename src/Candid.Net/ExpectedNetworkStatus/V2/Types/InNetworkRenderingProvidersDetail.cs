using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.ExpectedNetworkStatus.V2;

[Serializable]
public record InNetworkRenderingProvidersDetail : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("rendering_providers")]
    public IEnumerable<string> RenderingProviders { get; set; } = new List<string>();

    [JsonPropertyName("routed_payer_uuid")]
    public required string RoutedPayerUuid { get; set; }

    [JsonPropertyName("routed_billing_provider_id")]
    public required string RoutedBillingProviderId { get; set; }

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
