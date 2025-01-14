using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCapture.V1;

public record ChargeCaptureUpdate
{
    [JsonPropertyName("data")]
    public ChargeCaptureData? Data { get; set; }

    /// <summary>
    /// A client-specified unique ID to associate with this encounter;
    /// for example, your internal encounter ID or a Dr. Chrono encounter ID.
    /// This field should not contain PHI.
    /// </summary>
    [JsonPropertyName("charge_external_id")]
    public string? ChargeExternalId { get; set; }

    /// <summary>
    /// External URL reference that links to Charge Capture details within the external system (e.g. the EHR visit page).
    /// Send full URL format for the external link (e.g. https://emr_charge_capture_url.com/123).
    /// </summary>
    [JsonPropertyName("ehr_source_url")]
    public string? EhrSourceUrl { get; set; }

    /// <summary>
    /// The patient ID from the external EMR platform for the patient
    /// </summary>
    [JsonPropertyName("patient_external_id")]
    public string? PatientExternalId { get; set; }

    /// <summary>
    /// the status of the charge capture
    /// </summary>
    [JsonPropertyName("status")]
    public ChargeCaptureStatus? Status { get; set; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-24.
    /// This date must be the local date in the timezone where the service occurred.
    /// </summary>
    [JsonPropertyName("date_of_service")]
    public DateOnly? DateOfService { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
