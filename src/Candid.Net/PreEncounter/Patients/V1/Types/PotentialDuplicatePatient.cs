using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public record PotentialDuplicatePatient
{
    [JsonPropertyName("existing_patient_id")]
    public required string ExistingPatientId { get; set; }

    [JsonPropertyName("existing_patient_mrn")]
    public required string ExistingPatientMrn { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
