using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record FeeScheduleUploadRequest
{
    [JsonPropertyName("dry_run")]
    public required bool DryRun { get; init; }

    [JsonPropertyName("rates")]
    public IEnumerable<object> Rates { get; init; } = new List<object>();
}
