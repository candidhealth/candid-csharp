using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Appointments.V1;
using Candid.Net.PreEncounter.Coverages.V1;

#nullable enable

namespace Candid.Net.PreEncounter.Lists.V1;

public record PatientListItem
{
    [JsonPropertyName("patient")]
    public required Patients.V1.Patient Patient { get; set; }

    [JsonPropertyName("primary_coverage")]
    public MutableCoverage? PrimaryCoverage { get; set; }

    [JsonPropertyName("next_appointment")]
    public MutableAppointment? NextAppointment { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
