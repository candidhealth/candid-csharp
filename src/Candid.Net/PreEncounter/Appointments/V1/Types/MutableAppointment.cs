using global::Candid.Net;
using global::Candid.Net.Core;
using global::Candid.Net.PreEncounter.Common;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Appointments.V1;

/// <summary>
/// An object representing a appointment.
/// </summary>
[Serializable]
public record MutableAppointment : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The Candid-defined patient identifier.
    /// </summary>
    [JsonPropertyName("patient_id")]
    public required string PatientId { get; set; }

    [JsonPropertyName("start_timestamp")]
    public required DateTime StartTimestamp { get; set; }

    /// <summary>
    /// Defaults to PENDING. If status is NOT_READY, work_queue must be set. If status is READY, CHECKED_OUT, or NO_SHOW, work_queue must be null. checked_in_timestamp must be set if and only if status is CHECKED_IN or CHECKED_OUT, and checked_out_timestamp must be set if and only if status is CHECKED_OUT.
    /// </summary>
    [JsonPropertyName("status")]
    public AppointmentStatus? Status { get; set; }

    /// <summary>
    /// The reason the appointment is NOT_READY. Must only be set when status is NOT_READY; it is cleared otherwise. It is not recommended to change this value manually via API.
    /// </summary>
    [JsonPropertyName("not_ready_reason")]
    public NotReadyReason? NotReadyReason { get; set; }

    /// <summary>
    /// The method that set the appointment status to READY. It is not recommended to change this value manually via API. Must only be set when the status is READY, CHECKED_IN, CHECKED_OUT or NO_SHOW, it is cleared otherwise.
    /// </summary>
    [JsonPropertyName("ready_source")]
    public ReadySource? ReadySource { get; set; }

    /// <summary>
    /// The requested length of time allotted for the appointment. The units are in minutes.
    /// </summary>
    [JsonPropertyName("service_duration")]
    public required int ServiceDuration { get; set; }

    [JsonPropertyName("services")]
    public IEnumerable<Service> Services { get; set; } = new List<Service>();

    /// <summary>
    /// ID for the appointment/order for the event.
    /// </summary>
    [JsonPropertyName("placer_appointment_id")]
    public string? PlacerAppointmentId { get; set; }

    /// <summary>
    /// The name of the upstream system that placed this appointment.
    /// </summary>
    [JsonPropertyName("placer_system_name")]
    public string? PlacerSystemName { get; set; }

    /// <summary>
    /// Attending physician information. The attending physician will be stored as the Current MD for the patient.
    /// </summary>
    [JsonPropertyName("attending_doctor")]
    public ExternalProvider? AttendingDoctor { get; set; }

    [JsonPropertyName("estimated_copay_cents")]
    public int? EstimatedCopayCents { get; set; }

    /// <summary>
    /// The estimated amount the patient will be responsible for paying at the time of service. This does not include the copay.
    /// </summary>
    [JsonPropertyName("estimated_patient_responsibility_cents")]
    public int? EstimatedPatientResponsibilityCents { get; set; }

    [JsonPropertyName("patient_deposit_cents")]
    public int? PatientDepositCents { get; set; }

    [JsonPropertyName("appointment_details")]
    public string? AppointmentDetails { get; set; }

    /// <summary>
    /// The timestamp when the patient checked in for their appointment. Must be set when status is CHECKED_IN or CHECKED_OUT, and must be unset otherwise.
    /// </summary>
    [JsonPropertyName("checked_in_timestamp")]
    public DateTime? CheckedInTimestamp { get; set; }

    /// <summary>
    /// The timestamp when the patient checked out of their appointment. Must be set when status is CHECKED_OUT, and must be unset otherwise.
    /// </summary>
    [JsonPropertyName("checked_out_timestamp")]
    public DateTime? CheckedOutTimestamp { get; set; }

    /// <summary>
    /// The clinical context for the appointment.
    /// </summary>
    [JsonPropertyName("appointment_reason_detail")]
    public AppointmentReasonDetail? AppointmentReasonDetail { get; set; }

    /// <summary>
    /// True if medical necessity for this appointment has been verified.
    /// </summary>
    [JsonPropertyName("medical_necessity_verified")]
    public bool? MedicalNecessityVerified { get; set; }

    /// <summary>
    /// The prior authorization status for this appointment.
    /// </summary>
    [JsonPropertyName("prior_authorization_status")]
    public PriorAuthorizationStatus? PriorAuthorizationStatus { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// Contains the coded identification of the location being scheduled. Components: &lt;Identifier (ST)&gt;^&lt;Text (ST)&gt;
    /// </summary>
    [JsonPropertyName("location_resource_id")]
    public string? LocationResourceId { get; set; }

    /// <summary>
    /// True if the automated eligibility check has been completed. It is not recommended to change this value manually via API. This refers explicitly to the automated eligibility check that occurs a specific number of days before the appointment.
    /// </summary>
    [JsonPropertyName("automated_eligibility_check_complete")]
    public bool? AutomatedEligibilityCheckComplete { get; set; }

    /// <summary>
    /// The work queue that the appointment belongs to. It is not recommended to change this value manually via API. If status is NOT_READY, work_queue must be set. If status is READY, CHECKED_OUT or NO_SHOW, work_queue must be null.
    /// </summary>
    [JsonPropertyName("work_queue")]
    public AppointmentWorkQueue? WorkQueue { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
