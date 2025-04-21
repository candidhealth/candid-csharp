using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCaptureBundles.V1;

public record ChargeCaptureBundleSummary
{
    /// <summary>
    /// The count of charge captures which are not in a bundle or in a bundle with a status other than SUCCESSFUL.
    /// </summary>
    [JsonPropertyName("charge_capture_unbundled_count")]
    public required int ChargeCaptureUnbundledCount { get; set; }

    /// <summary>
    /// The count of charge capture bundles that have a bundle status of NOT_STARTED.
    /// </summary>
    [JsonPropertyName("charge_capture_bundles_not_started_count")]
    public required int ChargeCaptureBundlesNotStartedCount { get; set; }

    /// <summary>
    /// The count of charge capture bundles that have a bundle status of IN_ERROR.
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
