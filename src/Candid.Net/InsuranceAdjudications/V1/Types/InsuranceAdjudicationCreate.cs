using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.Payers.V3;
using Candid.Net.Remits.V1;

namespace Candid.Net.InsuranceAdjudications.V1;

[Serializable]
public record InsuranceAdjudicationCreate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("payer_identifier")]
    public required PayerIdentifier PayerIdentifier { get; set; }

    [JsonPropertyName("payee")]
    public required Payee Payee { get; set; }

    [JsonPropertyName("post_date")]
    public DateOnly? PostDate { get; set; }

    [JsonPropertyName("check_number")]
    public string? CheckNumber { get; set; }

    [JsonPropertyName("check_date")]
    public required DateOnly CheckDate { get; set; }

    [JsonPropertyName("check_amount_cents")]
    public int? CheckAmountCents { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }

    [JsonPropertyName("claims")]
    public Dictionary<string, IEnumerable<ClaimAdjudicationCreate>> Claims { get; set; } =
        new Dictionary<string, IEnumerable<ClaimAdjudicationCreate>>();

    [JsonPropertyName("remit_draft_id")]
    public string? RemitDraftId { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
