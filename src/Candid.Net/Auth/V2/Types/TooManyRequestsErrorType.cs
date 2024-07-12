using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Auth.V2;

public record TooManyRequestsErrorType
{
    [JsonPropertyName("message")]
    public required string Message { get; init; }
}
