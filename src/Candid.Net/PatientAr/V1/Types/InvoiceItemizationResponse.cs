using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PatientAr.V1;

[Serializable]
public record InvoiceItemizationResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The ID of the claim associated with the invoice itemization.
    /// </summary>
    [JsonPropertyName("claim_id")]
    public required string ClaimId { get; set; }

    /// <summary>
    /// The total patient balance in cents for the claim. Negative values indicate a credit balance.
    /// </summary>
    [JsonPropertyName("patient_balance_cents")]
    public required int PatientBalanceCents { get; set; }

    [JsonPropertyName("claim_level_patient_payments")]
    public required PatientPaymentInfo ClaimLevelPatientPayments { get; set; }

    /// <summary>
    /// A list of service line itemizations for the claim.
    /// </summary>
    [JsonPropertyName("service_line_itemization")]
    public IEnumerable<ServiceLineItemization> ServiceLineItemization { get; set; } =
        new List<ServiceLineItemization>();

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
