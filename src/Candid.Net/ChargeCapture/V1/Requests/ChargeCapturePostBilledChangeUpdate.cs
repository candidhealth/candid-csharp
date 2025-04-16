using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCapture.V1;

public record ChargeCapturePostBilledChangeUpdate
{
    /// <summary>
    /// Whether the change has been resolved. If true, the change will be marked as resolved.
    /// If false, the change will be marked as unresolved.
    /// </summary>
    [JsonPropertyName("resolved")]
    public required bool Resolved { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
