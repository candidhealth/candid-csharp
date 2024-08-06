using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record UnprocessableEntityErrorMessage
{
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}
