using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record AllocationCreate
{
    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; init; }

    [JsonPropertyName("target")]
    public required object Target { get; init; }
}
