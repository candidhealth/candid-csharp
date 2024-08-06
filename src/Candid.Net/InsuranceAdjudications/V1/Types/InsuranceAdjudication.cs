using System.Text.Json.Serialization;
using Candid.Net.InsuranceAdjudications.V1;

#nullable enable

namespace Candid.Net.InsuranceAdjudications.V1;

public record InsuranceAdjudication
{
    [JsonPropertyName("insurance_adjudication_id")]
    public required string InsuranceAdjudicationId { get; set; }

    [JsonPropertyName("payer_uuid")]
    public required string PayerUuid { get; set; }

    [JsonPropertyName("post_date")]
    public DateOnly? PostDate { get; set; }

    [JsonPropertyName("check_number")]
    public string? CheckNumber { get; set; }

    [JsonPropertyName("check_date")]
    public required DateOnly CheckDate { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }

    [JsonPropertyName("claims")]
    public Dictionary<string, IEnumerable<ClaimAdjudication>> Claims { get; set; } =
        new Dictionary<string, IEnumerable<ClaimAdjudication>>();
}
