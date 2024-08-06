using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record CashPayPayerErrorMessage
{
    [JsonPropertyName("message")]
    public required string Message { get; set; }
}
