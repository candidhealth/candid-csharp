using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

public record InNetworkRenderingProvidersDetail
{
    [JsonPropertyName("rendering_providers")]
    public IEnumerable<string> RenderingProviders { get; set; } = new List<string>();

    [JsonPropertyName("routed_payer_uuid")]
    public required string RoutedPayerUuid { get; set; }

    [JsonPropertyName("routed_billing_provider_id")]
    public required string RoutedBillingProviderId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
