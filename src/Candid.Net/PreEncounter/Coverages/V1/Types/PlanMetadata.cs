using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record PlanMetadata
{
    [JsonPropertyName("payer_name")]
    public string? PayerName { get; set; }

    [JsonPropertyName("insurance_type")]
    public string? InsuranceType { get; set; }

    [JsonPropertyName("insurance_type_code")]
    public string? InsuranceTypeCode { get; set; }

    [JsonPropertyName("plan_name")]
    public string? PlanName { get; set; }

    [JsonPropertyName("member_id")]
    public string? MemberId { get; set; }

    [JsonPropertyName("group_number")]
    public string? GroupNumber { get; set; }

    [JsonPropertyName("start_date")]
    public DateOnly? StartDate { get; set; }

    [JsonPropertyName("end_date")]
    public DateOnly? EndDate { get; set; }

    [JsonPropertyName("plan_dates")]
    public IEnumerable<PlanDate>? PlanDates { get; set; }

    [JsonPropertyName("subscriber")]
    public ExpandedMemberInfo? Subscriber { get; set; }

    [JsonPropertyName("dependent")]
    public ExpandedMemberInfo? Dependent { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
