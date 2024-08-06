using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record EncounterPatientControlNumberUniquenessErrorType
{
    [JsonPropertyName("patient_control_number")]
    public required string PatientControlNumber { get; set; }
}
