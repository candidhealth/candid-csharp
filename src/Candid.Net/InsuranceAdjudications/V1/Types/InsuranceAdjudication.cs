using System.Text.Json.Serialization;
using Candid.Net.InsuranceAdjudications.V1;

#nullable enable

namespace Candid.Net.InsuranceAdjudications.V1;

public record InsuranceAdjudication
{
    [JsonPropertyName("insurance_adjudication_id")]
    public required string InsuranceAdjudicationId { get; init; }

    [JsonPropertyName("payer_uuid")]
    public required string PayerUuid { get; init; }

    [JsonPropertyName("post_date")]
    public DateOnly? PostDate { get; init; }

    [JsonPropertyName("check_number")]
    public string? CheckNumber { get; init; }

    [JsonPropertyName("check_date")]
    public required DateOnly CheckDate { get; init; }

    [JsonPropertyName("note")]
    public string? Note { get; init; }

    [JsonPropertyName("claims")]
    public Dictionary<string, IEnumerable<ClaimAdjudication>> Claims { get; init; } =
        new Dictionary<string, IEnumerable<ClaimAdjudication>>();
}
