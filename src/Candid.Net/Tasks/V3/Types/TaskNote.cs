using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Tasks.V3;

public record TaskNote
{
    [JsonPropertyName("task_note_id")]
    public required string TaskNoteId { get; init; }

    [JsonPropertyName("text")]
    public required string Text { get; init; }

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; init; }

    [JsonPropertyName("author_name")]
    public required string AuthorName { get; init; }

    [JsonPropertyName("author_organization_name")]
    public required string AuthorOrganizationName { get; init; }
}
