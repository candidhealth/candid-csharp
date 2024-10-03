using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record PatientHistoryCategory
{
    [JsonPropertyName("category")]
    public required PatientHistoryCategoryEnum Category { get; set; }

    /// <summary>
    /// Must contain at least one item.
    /// </summary>
    [JsonPropertyName("questions")]
    public IEnumerable<IntakeQuestion> Questions { get; set; } = new List<IntakeQuestion>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
