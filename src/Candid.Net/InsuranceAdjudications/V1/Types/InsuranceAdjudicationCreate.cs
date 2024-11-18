using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.Remits.V1;

#nullable enable

namespace Candid.Net.InsuranceAdjudications.V1;

public record InsuranceAdjudicationCreate
{
    [JsonPropertyName("payer_identifier")]
    public required object PayerIdentifier { get; set; }

    [JsonPropertyName("payee")]
    public required Payee Payee { get; set; }

    [JsonPropertyName("post_date")]
    public DateOnly? PostDate { get; set; }

    [JsonPropertyName("check_number")]
    public string? CheckNumber { get; set; }

    [JsonPropertyName("check_date")]
    public required DateOnly CheckDate { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }

    [JsonPropertyName("claims")]
    public Dictionary<string, IEnumerable<ClaimAdjudicationCreate>> Claims { get; set; } =
        new Dictionary<string, IEnumerable<ClaimAdjudicationCreate>>();

    [JsonPropertyName("remit_draft_id")]
    public string? RemitDraftId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
