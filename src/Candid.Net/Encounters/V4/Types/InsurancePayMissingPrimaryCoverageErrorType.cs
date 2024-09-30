using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record InsurancePayMissingPrimaryCoverageErrorType
{
    [JsonPropertyName("patient_id")]
    public required string PatientId { get; set; }
}
