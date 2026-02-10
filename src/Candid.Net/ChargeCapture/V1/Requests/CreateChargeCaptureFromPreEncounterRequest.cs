using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.ChargeCapture.V1;

[Serializable]
public record CreateChargeCaptureFromPreEncounterRequest
{
    /// <summary>
    /// Charge Capture data contains all the fields needed to create an encounter, but listed as optional. Candid will use this data when attempting to bundle multiple Charge Captures into a single encounter.
    /// </summary>
    [JsonPropertyName("data")]
    public required ChargeCaptureData Data { get; set; }

    /// <summary>
    /// A client-specified unique ID to associate with this encounter; for example, your internal encounter ID or a Dr. Chrono encounter ID. This field should not contain PHI.
    /// </summary>
    [JsonPropertyName("charge_external_id")]
    public required string ChargeExternalId { get; set; }

    [JsonPropertyName("pre_encounter_patient_id")]
    public required string PreEncounterPatientId { get; set; }

    [JsonPropertyName("pre_encounter_appointment_ids")]
    public IEnumerable<string> PreEncounterAppointmentIds { get; set; } = new List<string>();

    /// <summary>
    /// An optional string field denoting the originating system of the charge.
    /// </summary>
    [JsonPropertyName("originating_system")]
    public string? OriginatingSystem { get; set; }

    /// <summary>
    /// An optional string field denoting the user defined category of the claim creation.
    /// </summary>
    [JsonPropertyName("claim_creation_category")]
    public string? ClaimCreationCategory { get; set; }

    /// <summary>
    /// External URL reference that links to Charge Capture details within the external system (e.g. the EHR visit page). Send full URL format for the external link (e.g. https://emr_charge_capture_url.com/123).
    /// </summary>
    [JsonPropertyName("ehr_source_url")]
    public string? EhrSourceUrl { get; set; }

    /// <summary>
    /// the status of the charge capture
    /// </summary>
    [JsonPropertyName("status")]
    public required ChargeCaptureStatus Status { get; set; }

    /// <summary>
    /// Provide external attachment IDs which have been uploaded to Candid. They will be associated with the Encounter at Encounter creation time.
    /// </summary>
    [JsonPropertyName("attachment_external_document_ids")]
    public IEnumerable<string>? AttachmentExternalDocumentIds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
