using System.Text.Json.Serialization;
using Candid.Net.Encounters.V4;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record ClinicalNoteCategory
{
    [JsonPropertyName("category")]
    public required NoteCategory Category { get; init; }

    [JsonPropertyName("notes")]
    public IEnumerable<string> Notes { get; init; } = new List<string>();

    [JsonPropertyName("notes_structured")]
    public IEnumerable<ClinicalNote>? NotesStructured { get; init; }
}
