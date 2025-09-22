using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PayerPlanGroups.V1;

public record PayerPlanGroup
{
    [JsonPropertyName("payer_plan_group_id")]
    public required string PayerPlanGroupId { get; set; }

    [JsonPropertyName("payer")]
    public required Payers.V3.Payer Payer { get; set; }

    [JsonPropertyName("is_active")]
    public required bool IsActive { get; set; }

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
