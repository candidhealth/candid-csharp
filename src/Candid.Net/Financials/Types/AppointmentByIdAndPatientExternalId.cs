using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public record AppointmentByIdAndPatientExternalId
{
    [JsonPropertyName("appointment_id")]
    public required string AppointmentId { get; set; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
