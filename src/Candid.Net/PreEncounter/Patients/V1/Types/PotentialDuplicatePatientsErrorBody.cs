using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public record PotentialDuplicatePatientsErrorBody
{
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    [JsonPropertyName("potential_duplicates")]
    public IEnumerable<PotentialDuplicatePatient> PotentialDuplicates { get; set; } =
        new List<PotentialDuplicatePatient>();

    [JsonPropertyName("message")]
    public required string Message { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
