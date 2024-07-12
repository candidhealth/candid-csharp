using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.InsuranceCards.V2;

public record InsuranceCardCreate
{
    [JsonPropertyName("member_id")]
    public required string MemberId { get; init; }

    [JsonPropertyName("payer_name")]
    public required string PayerName { get; init; }

    [JsonPropertyName("payer_id")]
    public required string PayerId { get; init; }

    [JsonPropertyName("rx_bin")]
    public string? RxBin { get; init; }

    [JsonPropertyName("rx_pcn")]
    public string? RxPcn { get; init; }

    [JsonPropertyName("image_url_front")]
    public string? ImageUrlFront { get; init; }

    [JsonPropertyName("image_url_back")]
    public string? ImageUrlBack { get; init; }

    [JsonPropertyName("emr_payer_crosswalk")]
    public EmrPayerCrosswalk? EmrPayerCrosswalk { get; init; }

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
