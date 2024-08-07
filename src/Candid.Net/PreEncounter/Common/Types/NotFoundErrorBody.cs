using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter;

public record NotFoundErrorBody
{
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    [JsonPropertyName("message")]
    public required string Message { get; set; }
}
