using System.Text.Json.Serialization;
using Candid.Net.Encounters.V4;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record ClinicalNoteCategoryCreate
{
    [JsonPropertyName("category")]
    public required NoteCategory Category { get; set; }

    [JsonPropertyName("notes")]
    public IEnumerable<ClinicalNote> Notes { get; set; } = new List<ClinicalNote>();
}
