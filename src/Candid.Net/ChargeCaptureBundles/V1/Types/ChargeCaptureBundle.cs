using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCaptureBundles.V1;

public record ChargeCaptureBundle
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("created_encounter_id")]
    public string? CreatedEncounterId { get; set; }

    /// <summary>
    /// Status of the Bundle, Successful means that the Bundle created a corresponding Claim
    /// </summary>
    [JsonPropertyName("status")]
    public required ChargeCaptureBundleStatus Status { get; set; }

    /// <summary>
    /// All the underlying ChargeCaptures that are present in a ChargeCaptureBundle.
    /// </summary>
    [JsonPropertyName("charge_captures")]
    public IEnumerable<ChargeCapture.V1.ChargeCapture> ChargeCaptures { get; set; } =
        new List<ChargeCapture.V1.ChargeCapture>();

    /// <summary>
    /// All errors that were found when the bundle was attempted to be created.
    /// Errors can correspond to the Bundle as a whole or specific underlying Charge Captures.
    /// </summary>
    [JsonPropertyName("errors")]
    public IEnumerable<ChargeBundleError> Errors { get; set; } = new List<ChargeBundleError>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
