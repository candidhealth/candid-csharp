using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.ChargeCapture.V1;

[Serializable]
public record ChargeCapturePostBilledChangeUpdate
{
    /// <summary>
    /// A list of UUIDs corresponding to ChargeCapturePostBilledChanges.
    /// All of the charges sent will be marked as resolved
    /// </summary>
    [JsonPropertyName("charge_capture_change_ids")]
    public IEnumerable<string> ChargeCaptureChangeIds { get; set; } = new List<string>();

    /// <summary>
    /// Whether the change has been resolved. If true, the change will be marked as resolved.
    /// If false, the change will be marked as unresolved.
    /// </summary>
    [JsonPropertyName("resolved")]
    public required bool Resolved { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
