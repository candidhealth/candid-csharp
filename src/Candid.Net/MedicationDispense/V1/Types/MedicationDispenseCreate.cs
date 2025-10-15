using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;
using Candid.Net.ServiceLines.V2;

namespace Candid.Net.MedicationDispense.V1;

[Serializable]
public record MedicationDispenseCreate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("medication_dispense_external_id")]
    public required string MedicationDispenseExternalId { get; set; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; set; }

    [JsonPropertyName("procedure_code")]
    public required string ProcedureCode { get; set; }

    [JsonPropertyName("quantity")]
    public required string Quantity { get; set; }

    [JsonPropertyName("units")]
    public required ServiceLineUnits Units { get; set; }

    [JsonPropertyName("date_of_service")]
    public required DateOnly DateOfService { get; set; }

    [JsonPropertyName("drug_identification")]
    public DrugIdentification? DrugIdentification { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("modifiers")]
    public IEnumerable<ProcedureModifier>? Modifiers { get; set; }

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
