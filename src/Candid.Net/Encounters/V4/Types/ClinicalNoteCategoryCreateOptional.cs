using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record ClinicalNoteCategoryCreateOptional
{
    [JsonPropertyName("category")]
    public NoteCategory? Category { get; set; }

    [JsonPropertyName("notes")]
    public IEnumerable<ClinicalNoteOptional>? Notes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
