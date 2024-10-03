using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record ClinicalNoteCategory
{
    [JsonPropertyName("category")]
    public required NoteCategory Category { get; set; }

    [JsonPropertyName("notes")]
    public IEnumerable<string> Notes { get; set; } = new List<string>();

    [JsonPropertyName("notes_structured")]
    public IEnumerable<ClinicalNote>? NotesStructured { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
