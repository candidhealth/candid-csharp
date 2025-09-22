using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public record InferredPatientMetadata
{
    [JsonPropertyName("inferred_encounter_id")]
    public required string InferredEncounterId { get; set; }

    [JsonPropertyName("inferred_encounter_latest_date_of_service")]
    public required DateOnly InferredEncounterLatestDateOfService { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
