using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record ClinicalNote
{
    [JsonPropertyName("text")]
    public required string Text { get; init; }

    [JsonPropertyName("author_name")]
    public required string AuthorName { get; init; }

    [JsonPropertyName("author_npi")]
    public string? AuthorNpi { get; init; }

    [JsonPropertyName("timestamp")]
    public required DateTime Timestamp { get; init; }
}
