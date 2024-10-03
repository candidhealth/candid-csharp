using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Tasks.V3;

public record TaskNote
{
    [JsonPropertyName("task_note_id")]
    public required string TaskNoteId { get; set; }

    [JsonPropertyName("text")]
    public required string Text { get; set; }

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("author_name")]
    public required string AuthorName { get; set; }

    [JsonPropertyName("author_organization_name")]
    public required string AuthorOrganizationName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
