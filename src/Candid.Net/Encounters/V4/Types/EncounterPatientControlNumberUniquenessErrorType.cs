using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record EncounterPatientControlNumberUniquenessErrorType
{
    [JsonPropertyName("patient_control_number")]
    public required string PatientControlNumber { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
