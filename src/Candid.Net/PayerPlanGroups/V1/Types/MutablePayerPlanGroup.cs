using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PayerPlanGroups.V1;

public record MutablePayerPlanGroup
{
    [JsonPropertyName("plan_group_name")]
    public required string PlanGroupName { get; set; }

    [JsonPropertyName("payer_uuid")]
    public required string PayerUuid { get; set; }

    [JsonPropertyName("plan_type")]
    public required SourceOfPaymentCode PlanType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
