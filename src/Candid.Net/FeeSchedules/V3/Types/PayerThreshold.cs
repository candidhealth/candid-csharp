using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.FeeSchedules.V3;

/// <summary>
/// Rate thresholds that determine fee schedule rate matching behavior.  When a service line is adjudicated by a payer Candid determines if the payer's
/// allowed amount "matches" the rate value.  If the allowed amount doesn't equal the rate value, Candid moves the claim to a PAID_INCORRECTLY state.  These
/// optional thresholds allow a user to set wiggle room to avoid claims moving to PAID_INCORRECTLY and instead have them move directly to FINALIZED_PAID
/// when the payer's allowed amount is greater than [rate_cents - lower_threshold_cents] and less than [rate_cents + upper_threshold_cents].
///
/// Additionally, a client can set disable_paid_incorrectly to avoid the PAID_INCORRECTLY claim status entirely.
/// </summary>
[Serializable]
public record PayerThreshold : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("upper_threshold_cents")]
    public int? UpperThresholdCents { get; set; }

    [JsonPropertyName("lower_threshold_cents")]
    public int? LowerThresholdCents { get; set; }

    [JsonPropertyName("disable_paid_incorrectly")]
    public required bool DisablePaidIncorrectly { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
