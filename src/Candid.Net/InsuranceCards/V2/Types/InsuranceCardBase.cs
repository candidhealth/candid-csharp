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
    public string? GroupNumber { get; init; }

    /// <summary>
    /// Box 11c on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("plan_name")]
    public string? PlanName { get; init; }

    [JsonPropertyName("plan_type")]
    public SourceOfPaymentCode? PlanType { get; init; }

    [JsonPropertyName("insurance_type")]
    public InsuranceTypeCode? InsuranceType { get; init; }
}
