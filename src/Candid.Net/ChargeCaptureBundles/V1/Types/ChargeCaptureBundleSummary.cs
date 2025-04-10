using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCaptureBundles.V1;

public record ChargeCaptureBundleSummary
{
    /// <summary>
    /// The count of charge captures which are not bundled.
    /// </summary>
    [JsonPropertyName("charge_capture_unbundled_count")]
    public required int ChargeCaptureUnbundledCount { get; set; }

    /// <summary>
    /// The count of charge capture bundles that are in an error state.
    /// </summary>
    [JsonPropertyName("charge_capture_bundles_in_error_count")]
    public required int ChargeCaptureBundlesInErrorCount { get; set; }

    /// <summary>
    /// The number of ChargeCapturePostBilledChange items that are unresolved.
    /// </summary>
    [JsonPropertyName("charge_capture_unresolved_change_count")]
    public required int ChargeCaptureUnresolvedChangeCount { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
