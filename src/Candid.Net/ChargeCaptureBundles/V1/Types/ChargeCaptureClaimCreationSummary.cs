using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCaptureBundles.V1;

public record ChargeCaptureClaimCreationSummary
{
    /// <summary>
    /// The count of charge captures which are not part of a Claim Creation.
    /// </summary>
    [JsonPropertyName("charge_capture_charges_not_linked_to_claims_count")]
    public required int ChargeCaptureChargesNotLinkedToClaimsCount { get; set; }

    /// <summary>
    /// The count of charge capture claim_creations that have a Claim Creation status of NOT_STARTED.
    /// </summary>
    [JsonPropertyName("charge_capture_claim_creations_not_started_count")]
    public required int ChargeCaptureClaimCreationsNotStartedCount { get; set; }

    /// <summary>
    /// The count of charge capture claim_creations that have a Claim Creation status of HELD.
    /// </summary>
    [JsonPropertyName("charge_capture_held_claim_creations_count")]
    public required int ChargeCaptureHeldClaimCreationsCount { get; set; }

    /// <summary>
    /// The count of charge capture claim_creations that have a Claim Creation status of IN_ERROR.
    /// </summary>
    [JsonPropertyName("charge_capture_claim_creations_in_error_count")]
    public required int ChargeCaptureClaimCreationsInErrorCount { get; set; }

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
