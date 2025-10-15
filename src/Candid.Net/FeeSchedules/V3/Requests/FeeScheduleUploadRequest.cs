using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.FeeSchedules.V3;

[Serializable]
public record FeeScheduleUploadRequest
{
    [JsonPropertyName("dry_run")]
    public required bool DryRun { get; set; }

    [JsonPropertyName("rates")]
    public IEnumerable<RateUpload> Rates { get; set; } = new List<RateUpload>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
