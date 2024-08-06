using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record ClinicalNote
{
    [JsonPropertyName("text")]
    public required string Text { get; set; }

    [JsonPropertyName("author_name")]
    public required string AuthorName { get; set; }

    [JsonPropertyName("author_npi")]
    public string? AuthorNpi { get; set; }

    [JsonPropertyName("timestamp")]
    public required DateTime Timestamp { get; set; }
}
