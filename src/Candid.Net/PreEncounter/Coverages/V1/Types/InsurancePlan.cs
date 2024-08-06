using System.Text.Json.Serialization;
using Candid.Net.PreEncounter;
using Candid.Net.PreEncounter.Coverages.V1;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record InsurancePlan
{
    [JsonPropertyName("member_id")]
    public required string MemberId { get; set; }

    [JsonPropertyName("payer_id")]
    public required string PayerId { get; set; }

    [JsonPropertyName("payer_name")]
    public required string PayerName { get; set; }

    [JsonPropertyName("group_number")]
    public string? GroupNumber { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public NetworkType? Type { get; set; }

    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    [JsonPropertyName("insurance_card_image_locator")]
    public string? InsuranceCardImageLocator { get; set; }
}
