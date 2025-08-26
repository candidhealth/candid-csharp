using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PatientAr.V1;

public record InventoryRecord
{
    [JsonPropertyName("claim_id")]
    public required string ClaimId { get; set; }

    [JsonPropertyName("encounter_id")]
    public required string EncounterId { get; set; }

    [JsonPropertyName("timestamp")]
    public required DateTime Timestamp { get; set; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; set; }

    [JsonPropertyName("patient_ar_status")]
    public required PatientArStatus PatientArStatus { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
