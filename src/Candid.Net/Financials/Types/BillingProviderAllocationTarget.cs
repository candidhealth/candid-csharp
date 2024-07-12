using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record BillingProviderAllocationTarget
{
    [JsonPropertyName("billing_provider_id")]
    public required Guid BillingProviderId { get; init; }
}
