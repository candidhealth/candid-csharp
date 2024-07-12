using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Remits.V1;

public record Payee
{
    [JsonPropertyName("payee_name")]
    public required string PayeeName { get; init; }

    [JsonPropertyName("payee_identifier")]
    public required object PayeeIdentifier { get; init; }
}
