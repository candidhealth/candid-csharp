using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record UnauthorizedErrorMessage
{
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}
