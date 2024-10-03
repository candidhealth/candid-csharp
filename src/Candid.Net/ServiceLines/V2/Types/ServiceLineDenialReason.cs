using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ServiceLines.V2;

public record ServiceLineDenialReason
{
    /// <summary>
    /// Text of the denial reason
    /// </summary>
    [JsonPropertyName("reason")]
    public DenialReasonContent? Reason { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
