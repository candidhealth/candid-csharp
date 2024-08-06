using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter;

public record ErrorBase
{
    [JsonPropertyName("message")]
    public required string Message { get; set; }
}
