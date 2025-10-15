using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.ServiceLines.V2;

[Serializable]
public record ServiceLineAdjustment : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("adjustment_group_code")]
    public string? AdjustmentGroupCode { get; set; }

    [JsonPropertyName("adjustment_reason_code")]
    public string? AdjustmentReasonCode { get; set; }

    [JsonPropertyName("adjustment_amount_cents")]
    public int? AdjustmentAmountCents { get; set; }

    [JsonPropertyName("adjustment_note")]
    public string? AdjustmentNote { get; set; }

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
