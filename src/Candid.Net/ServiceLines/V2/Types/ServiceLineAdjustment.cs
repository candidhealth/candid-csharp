using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.ServiceLines.V2;

public record ServiceLineAdjustment
{
    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; init; }

    [JsonPropertyName("adjustment_group_code")]
    public string? AdjustmentGroupCode { get; init; }

    [JsonPropertyName("adjustment_reason_code")]
    public string? AdjustmentReasonCode { get; init; }

    [JsonPropertyName("adjustment_amount_cents")]
    public int? AdjustmentAmountCents { get; init; }

    [JsonPropertyName("adjustment_note")]
    public string? AdjustmentNote { get; init; }
}
