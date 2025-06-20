using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record PatientHistoryCategoryOptional
{
    [JsonPropertyName("category")]
    public PatientHistoryCategoryEnum? Category { get; set; }

    /// <summary>
    /// Must contain at least one item.
    /// </summary>
    [JsonPropertyName("questions")]
    public IEnumerable<IntakeQuestionOptional>? Questions { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
