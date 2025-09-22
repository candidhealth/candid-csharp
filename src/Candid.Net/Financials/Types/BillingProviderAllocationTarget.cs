using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Financials;

public record BillingProviderAllocationTarget
{
    [JsonPropertyName("billing_provider_id")]
    public required string BillingProviderId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
