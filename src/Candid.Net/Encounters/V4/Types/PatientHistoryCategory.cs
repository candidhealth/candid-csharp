using System.Text.Json.Serialization;
using Candid.Net.Encounters.V4;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record PatientHistoryCategory
{
    [JsonPropertyName("category")]
    public required PatientHistoryCategoryEnum Category { get; init; }

    /// <summary>
    /// Must contain at least one item.
    /// </summary>
    [JsonPropertyName("questions")]
    public IEnumerable<IntakeQuestion> Questions { get; init; } = new List<IntakeQuestion>();
}
