using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record AppointmentByIdAndPatientExternalId
{
    [JsonPropertyName("appointment_id")]
    public required string AppointmentId { get; set; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; set; }
}
