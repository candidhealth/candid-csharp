using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ServiceLines.V2;

public record ServiceLineAdjustment
{
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
