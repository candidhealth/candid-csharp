using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ServiceLines.V2;

public record DrugIdentificationOptional
{
    [JsonPropertyName("service_id_qualifier")]
    public ServiceIdQualifier? ServiceIdQualifier { get; set; }

    [JsonPropertyName("national_drug_code")]
    public string? NationalDrugCode { get; set; }

    [JsonPropertyName("national_drug_unit_count")]
    public string? NationalDrugUnitCount { get; set; }

    [JsonPropertyName("measurement_unit_code")]
    public MeasurementUnitCode? MeasurementUnitCode { get; set; }

    [JsonPropertyName("link_sequence_number")]
    public string? LinkSequenceNumber { get; set; }

    [JsonPropertyName("pharmacy_prescription_number")]
    public string? PharmacyPrescriptionNumber { get; set; }

    [JsonPropertyName("conversion_formula")]
    public string? ConversionFormula { get; set; }

    [JsonPropertyName("drug_description")]
    public string? DrugDescription { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
