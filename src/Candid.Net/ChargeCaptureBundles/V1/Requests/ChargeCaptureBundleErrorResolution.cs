using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.ChargeCaptureBundles.V1;

[Serializable]
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

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
