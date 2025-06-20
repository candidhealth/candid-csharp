using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCaptureBundles.V1;

public record ChargeCaptureBundleErrorResolution
{
    /// <summary>
    /// A string, denoting who resolved the error for audit trail purposes.
    /// </summary>
    [JsonPropertyName("resolved_by")]
    public string? ResolvedBy { get; set; }

    /// <summary>
    /// A string denoting why or how the error was dealt with for audit trail purposes.
    /// </summary>
    [JsonPropertyName("resolution_reason")]
    public string? ResolutionReason { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
