using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record Allocation
{
    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonPropertyName("target")]
    public required object Target { get; set; }
}
