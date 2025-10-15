using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PatientAr.V1;

[Serializable]
public record ServiceLineItemization : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The ID of the service line.
    /// </summary>
    [JsonPropertyName("service_line_id")]
    public required string ServiceLineId { get; set; }

    /// <summary>
    /// The procedure code (CPT/HCPCS) associated with the service line.
    /// </summary>
    [JsonPropertyName("procedure_code")]
    public required string ProcedureCode { get; set; }

    /// <summary>
    /// The date of service for the service line.
    /// </summary>
    [JsonPropertyName("date_of_service")]
    public required DateOnly DateOfService { get; set; }

    /// <summary>
    /// The total patient balance in cents for the service line. Negative values indicate a credit balance.
    /// </summary>
    [JsonPropertyName("patient_balance_cents")]
    public required int PatientBalanceCents { get; set; }

    /// <summary>
    /// The total charge amount in cents for the service line.
    /// </summary>
    [JsonPropertyName("charge_amount_cents")]
    public required int ChargeAmountCents { get; set; }

    [JsonPropertyName("insurance_adjustments")]
    public required InsuranceAdjustmentInfo InsuranceAdjustments { get; set; }

    [JsonPropertyName("insurance_payments")]
    public required InsurancePaymentInfo InsurancePayments { get; set; }

    [JsonPropertyName("non_insurance_adjustments")]
    public required NonInsuranceAdjustmentInfo NonInsuranceAdjustments { get; set; }

    [JsonPropertyName("non_insurance_payments")]
    public required NonInsurancePaymentInfo NonInsurancePayments { get; set; }

    [JsonPropertyName("patient_adjustments")]
    public required PatientAdjustmentInfo PatientAdjustments { get; set; }

    [JsonPropertyName("patient_payments")]
    public required PatientPaymentInfo PatientPayments { get; set; }

    /// <summary>
    /// The copay amount in cents for the service line.
    /// </summary>
    [JsonPropertyName("copay_cents")]
    public required int CopayCents { get; set; }

    /// <summary>
    /// The coinsurance amount in cents for the service line.
    /// </summary>
    [JsonPropertyName("coinsurance_cents")]
    public required int CoinsuranceCents { get; set; }

    /// <summary>
    /// The deductible amount in cents for the service line.
    /// </summary>
    [JsonPropertyName("deductible_cents")]
    public required int DeductibleCents { get; set; }

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
