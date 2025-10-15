using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PatientPayments.V3;

[Serializable]
public record PatientPayment : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("patient_payment_id")]
    public required string PatientPaymentId { get; set; }

    [JsonPropertyName("organization_id")]
    public required string OrganizationId { get; set; }

    [JsonPropertyName("source_internal_id")]
    public required string SourceInternalId { get; set; }

    [JsonPropertyName("source")]
    public required PatientPaymentSource Source { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonPropertyName("payment_timestamp")]
    public DateTime? PaymentTimestamp { get; set; }

    [JsonPropertyName("status")]
    public PatientPaymentStatus? Status { get; set; }

    [JsonPropertyName("payment_name")]
    public string? PaymentName { get; set; }

    [JsonPropertyName("payment_note")]
    public string? PaymentNote { get; set; }

    [JsonPropertyName("patient_external_id")]
    public string? PatientExternalId { get; set; }

    [JsonPropertyName("encounter_external_id")]
    public string? EncounterExternalId { get; set; }

    [JsonPropertyName("service_line_id")]
    public string? ServiceLineId { get; set; }

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
