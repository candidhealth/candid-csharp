using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCapture.V1;

public record ChargeCapture
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("status")]
    public required ChargeCaptureStatus Status { get; set; }

    [JsonPropertyName("charge_capture_data")]
    public required ChargeCaptureData ChargeCaptureData { get; set; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; set; }

    [JsonPropertyName("encounter_external_id")]
    public required string EncounterExternalId { get; set; }

    [JsonPropertyName("ehr_source_url")]
    public string? EhrSourceUrl { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
