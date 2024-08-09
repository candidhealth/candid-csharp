using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.ServiceLines.V2;

public record ServiceLineDenialReason
{
    /// <summary>
    /// Text of the denial reason
    /// </summary>
    [JsonPropertyName("reason")]
    public DenialReasonContent? Reason { get; set; }
}
