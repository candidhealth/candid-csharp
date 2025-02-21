using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record PayerPlanGroupDoesNotMatchRatePayerError
{
    [JsonPropertyName("rate_payer_uuid")]
    public required string RatePayerUuid { get; set; }

    [JsonPropertyName("payer_plan_group_payer_uuid")]
    public required string PayerPlanGroupPayerUuid { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
