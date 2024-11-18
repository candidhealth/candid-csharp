using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Appointments.V1;
using Candid.Net.PreEncounter.Coverages.V1;
using Candid.Net.PreEncounter.Patients.V1;

#nullable enable

namespace Candid.Net.PreEncounter.Lists.V1;

public record AppointmentListItem
{
    [JsonPropertyName("appointment")]
    public required Appointment Appointment { get; set; }

    [JsonPropertyName("patient")]
    public required MutablePatient Patient { get; set; }

    [JsonPropertyName("primary_coverage")]
    public MutableCoverage? PrimaryCoverage { get; set; }

    [JsonPropertyName("primary_service_type")]
    public UniversalServiceIdentifier? PrimaryServiceType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
