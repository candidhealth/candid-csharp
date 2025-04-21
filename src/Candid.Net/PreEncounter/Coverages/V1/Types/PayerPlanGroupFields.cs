using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record PayerPlanGroupFields
{
    [JsonPropertyName("payer_plan_group_id")]
    public required string PayerPlanGroupId { get; set; }

    [JsonPropertyName("payer_id")]
    public required string PayerId { get; set; }

    [JsonPropertyName("payer_name")]
    public required string PayerName { get; set; }

    [JsonPropertyName("plan_type")]
    public required NetworkType PlanType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
