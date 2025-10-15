using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.ServiceLines.V2;
using Candid.Net.X12.V1;

namespace Candid.Net.InsuranceAdjudications.V1;

[Serializable]
public record ServiceLineAdjudicationCreate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Will be treated as a denial if present
    /// </summary>
    [JsonPropertyName("denial_reason")]
    public DenialReasonContent? DenialReason { get; set; }

    [JsonPropertyName("insurance_allowed_amount_cents")]
    public int? InsuranceAllowedAmountCents { get; set; }

    [JsonPropertyName("insurance_paid_amount_cents")]
    public int? InsurancePaidAmountCents { get; set; }

    [JsonPropertyName("deductible_amount_cents")]
    public int? DeductibleAmountCents { get; set; }

    [JsonPropertyName("coinsurance_amount_cents")]
    public int? CoinsuranceAmountCents { get; set; }

    [JsonPropertyName("copay_amount_cents")]
    public int? CopayAmountCents { get; set; }

    [JsonPropertyName("carcs")]
    public IEnumerable<ClaimAdjustmentReasonCode> Carcs { get; set; } =
        new List<ClaimAdjustmentReasonCode>();

    [JsonPropertyName("rarcs")]
    public IEnumerable<RemittanceAdviceRemarkCode> Rarcs { get; set; } =
        new List<RemittanceAdviceRemarkCode>();

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
