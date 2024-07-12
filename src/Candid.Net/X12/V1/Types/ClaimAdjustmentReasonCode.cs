using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.X12.V1;

#nullable enable

namespace Candid.Net.X12.V1;

public record ClaimAdjustmentReasonCode
{
    [JsonPropertyName("group_code")]
    public required ClaimAdjustmentGroupCodes GroupCode { get; init; }

    [JsonPropertyName("reason_code")]
    public required Carc ReasonCode { get; init; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; init; }
}
