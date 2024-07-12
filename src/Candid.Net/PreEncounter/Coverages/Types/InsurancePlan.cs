using System.Text.Json.Serialization;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter;

public record InsurancePlan
{
    [JsonPropertyName("memberId")]
    public required string MemberId { get; init; }

    [JsonPropertyName("payerId")]
    public required string PayerId { get; init; }

    [JsonPropertyName("payerName")]
    public required string PayerName { get; init; }

    [JsonPropertyName("groupNumber")]
    public string? GroupNumber { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("type")]
    public CoverageType? Type { get; init; }

    [JsonPropertyName("period")]
    public Period? Period { get; init; }

    [JsonPropertyName("insuranceCardImageLocator")]
    public string? InsuranceCardImageLocator { get; init; }
}
