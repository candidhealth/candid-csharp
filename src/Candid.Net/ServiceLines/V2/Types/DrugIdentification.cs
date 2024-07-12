using System.Text.Json.Serialization;
using Candid.Net.ServiceLines.V2;

#nullable enable

namespace Candid.Net.ServiceLines.V2;

public record DrugIdentification
{
    [JsonPropertyName("service_id_qualifier")]
    public required ServiceIdQualifier ServiceIdQualifier { get; init; }

    [JsonPropertyName("national_drug_code")]
    public required string NationalDrugCode { get; init; }

    [JsonPropertyName("national_drug_unit_count")]
    public required string NationalDrugUnitCount { get; init; }

    [JsonPropertyName("measurement_unit_code")]
    public required MeasurementUnitCode MeasurementUnitCode { get; init; }

    [JsonPropertyName("link_sequence_number")]
    public string? LinkSequenceNumber { get; init; }

    [JsonPropertyName("pharmacy_prescription_number")]
    public string? PharmacyPrescriptionNumber { get; init; }
}
