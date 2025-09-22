using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Diagnoses;

public record DisallowMultiplePrimaryDiagnosisError
{
    [JsonPropertyName("existing_primary_diagnosis_id")]
    public required string ExistingPrimaryDiagnosisId { get; set; }

    [JsonPropertyName("new_primary_diagnosis_id")]
    public required string NewPrimaryDiagnosisId { get; set; }

    [JsonPropertyName("message")]
    public required string Message { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
