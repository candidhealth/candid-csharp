using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Coverages.V1;
using Candid.Net.PreEncounter.Patients.V1;

#nullable enable

namespace Candid.Net.PreEncounter.Appointments.V1;

public record Visit
{
    [JsonPropertyName("patient_id")]
    public required string PatientId { get; set; }

    [JsonPropertyName("patient")]
    public required MutablePatientWithMrn Patient { get; set; }

    [JsonPropertyName("start_time")]
    public required DateTime StartTime { get; set; }

    [JsonPropertyName("status")]
    public required AppointmentStatus Status { get; set; }

    [JsonPropertyName("primary_coverage")]
    public MutableCoverage? PrimaryCoverage { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
