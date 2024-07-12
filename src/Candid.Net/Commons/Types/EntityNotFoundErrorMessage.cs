using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record EntityNotFoundErrorMessage
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }
}
