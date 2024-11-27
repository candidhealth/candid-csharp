using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Notes.V1;

public record MutableNote
{
    [JsonPropertyName("value")]
    public required string Value { get; set; }

    [JsonPropertyName("author_email")]
    public string? AuthorEmail { get; set; }

    [JsonPropertyName("author_name")]
    public string? AuthorName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
