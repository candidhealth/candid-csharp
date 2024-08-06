using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record HttpServiceUnavailableErrorMessage
{
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}
