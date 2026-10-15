using global::Candid.Net;
using global::Candid.Net.Commons;
using global::Candid.Net.Core;
using global::Candid.Net.X12.V1;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Eras;

[Serializable]
public record EraAdjustment : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("adjustment_group_code")]
    public required ClaimAdjustmentGroupCodes AdjustmentGroupCode { get; set; }

    [JsonPropertyName("adjustment_reason_code")]
    public required Carc AdjustmentReasonCode { get; set; }

    [JsonPropertyName("adjustment_amount_cents")]
    public int? AdjustmentAmountCents { get; set; }

    [JsonPropertyName("adjustment_quantity")]
    public int? AdjustmentQuantity { get; set; }

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
