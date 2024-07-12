using System.Text.Json.Serialization;
using Candid.Net.InsuranceAdjudications.V1;
using Candid.Net.Remits.V1;

#nullable enable

namespace Candid.Net.InsuranceAdjudications.V1;

public record InsuranceAdjudicationCreate
{
    [JsonPropertyName("payer_identifier")]
    public required object PayerIdentifier { get; init; }

    [JsonPropertyName("payee")]
    public required Payee Payee { get; init; }

    [JsonPropertyName("post_date")]
    public DateOnly? PostDate { get; init; }

    [JsonPropertyName("check_number")]
    public string? CheckNumber { get; init; }

    [JsonPropertyName("check_date")]
    public required DateOnly CheckDate { get; init; }

    [JsonPropertyName("note")]
    public string? Note { get; init; }

    [JsonPropertyName("claims")]
    public Dictionary<Guid, IEnumerable<ClaimAdjudicationCreate>> Claims { get; init; } =
        new Dictionary<Guid, IEnumerable<ClaimAdjudicationCreate>>();
}
