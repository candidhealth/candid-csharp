using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.InsuranceCards.V2;

public record InsuranceCardBase
{
    /// <summary>
    /// Box 11 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("group_number")]
    public string? GroupNumber { get; set; }

    /// <summary>
    /// Box 11c on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("plan_name")]
    public string? PlanName { get; set; }

    [JsonPropertyName("plan_type")]
    public SourceOfPaymentCode? PlanType { get; set; }

    [JsonPropertyName("insurance_type")]
    public InsuranceTypeCode? InsuranceType { get; set; }
}
