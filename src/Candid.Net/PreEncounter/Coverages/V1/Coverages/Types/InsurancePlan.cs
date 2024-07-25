using System.Text.Json.Serialization;
using Candid.Net.PreEncounter;
using Candid.Net.PreEncounter.Coverages.V1;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record InsurancePlan
{
    [JsonPropertyName("member_id")]
    public required string MemberId { get; init; }

    [JsonPropertyName("payer_id")]
    public required string PayerId { get; init; }

    [JsonPropertyName("payer_name")]
    public required string PayerName { get; init; }

    [JsonPropertyName("group_number")]
    public string? GroupNumber { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("type")]
    public CoverageType? Type { get; init; }

    [JsonPropertyName("period")]
    public Period? Period { get; init; }

    [JsonPropertyName("insurance_card_image_locator")]
    public string? InsuranceCardImageLocator { get; init; }
}
