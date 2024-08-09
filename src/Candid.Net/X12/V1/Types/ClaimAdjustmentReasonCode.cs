using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.X12.V1;

public record ClaimAdjustmentReasonCode
{
    [JsonPropertyName("group_code")]
    public required ClaimAdjustmentGroupCodes GroupCode { get; set; }

    [JsonPropertyName("reason_code")]
    public required Carc ReasonCode { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }
}
