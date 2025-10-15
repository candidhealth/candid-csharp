using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.EraCommons;
using Candid.Net.X12.V1;

namespace Candid.Net.InsuranceAdjudications.V1;

[Serializable]
public record ClaimAdjudicationCreate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("claim_status_code")]
    public required ClaimStatusCodeCreate ClaimStatusCode { get; set; }

    [JsonPropertyName("insurance_paid_amount_cents")]
    public int? InsurancePaidAmountCents { get; set; }

    [JsonPropertyName("charge_amount_cents")]
    public int? ChargeAmountCents { get; set; }

    [JsonPropertyName("service_lines")]
    public Dictionary<
        string,
        IEnumerable<ServiceLineAdjudicationCreate>
    > ServiceLines { get; set; } =
        new Dictionary<string, IEnumerable<ServiceLineAdjudicationCreate>>();

    [JsonPropertyName("payer_claim_number")]
    public string? PayerClaimNumber { get; set; }

    [JsonPropertyName("carcs")]
    public IEnumerable<ClaimAdjustmentReasonCode> Carcs { get; set; } =
        new List<ClaimAdjustmentReasonCode>();

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
