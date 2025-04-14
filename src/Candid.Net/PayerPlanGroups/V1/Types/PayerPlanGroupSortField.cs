using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PayerPlanGroups.V1;

[JsonConverter(typeof(EnumSerializer<PayerPlanGroupSortField>))]
public enum PayerPlanGroupSortField
{
    [EnumMember(Value = "plan_group_name")]
    PlanGroupName,

    [EnumMember(Value = "plan_type")]
    PlanType,

    [EnumMember(Value = "created_at")]
    CreatedAt,
}
