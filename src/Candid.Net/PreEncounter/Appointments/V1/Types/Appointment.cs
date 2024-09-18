using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter.Appointments.V1;

public record Appointment
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The organization that owns this appointment.
    /// </summary>
    [JsonPropertyName("organization_id")]
    public required string OrganizationId { get; set; }

    /// <summary>
    /// True if the appointment is deactivated. Deactivated appointments are not returned in search results but are returned in all other endpoints including scan.
    /// </summary>
    [JsonPropertyName("deactivated")]
    public required bool Deactivated { get; set; }

    /// <summary>
    /// The version of the appointment. Any update to any property of an appointment object will create a new version.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; set; }

    [JsonPropertyName("updated_at")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// The user ID of the user who last updated the appointment.
    /// </summary>
    [JsonPropertyName("updating_user_id")]
    public required string UpdatingUserId { get; set; }

    /// <summary>
    /// The Candid-defined patient identifier.
    /// </summary>
    [JsonPropertyName("patient_id")]
    public required string PatientId { get; set; }

    [JsonPropertyName("start_timestamp")]
    public required DateTime StartTimestamp { get; set; }

    /// <summary>
    /// Defaults to PENDING. If status is NOT_READY, work_queue must be set. If status is READY or CHECKED_IN, work_queue must be null. If status is CHECKED_IN, checked_in_timestamp must be set. If checked_in_timestamp is set, status must be CHECKED_IN.
    /// </summary>
    [JsonPropertyName("status")]
    public AppointmentStatus? Status { get; set; }

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

    [JsonPropertyName("estimated_copay_cents")]
    public int? EstimatedCopayCents { get; set; }

    [JsonPropertyName("estimated_patient_responsibility_cents")]
    public int? EstimatedPatientResponsibilityCents { get; set; }

    [JsonPropertyName("patient_deposit_cents")]
    public int? PatientDepositCents { get; set; }

    /// <summary>
    /// The timestamp when the patient checked in for their appointment. If status is CHECKED_IN, checked_in_timestamp must be set. If checked_in_timestamp is set, status must be CHECKED_IN.
    /// </summary>
    [JsonPropertyName("checked_in_timestamp")]
    public DateTime? CheckedInTimestamp { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// Contains the coded identification of the location being scheduled. Components: <Identifier (ST)>^<Text (ST)>
    /// </summary>
    [JsonPropertyName("location_resource_id")]
    public string? LocationResourceId { get; set; }

    /// <summary>
    /// True if the automated eligibility check has been completed. It is not recommended to change this value manually via API. This refers explicitly to the automated eligibility check that occurs a specific number of days before the appointment.
    /// </summary>
    [JsonPropertyName("automated_eligibility_check_complete")]
    public bool? AutomatedEligibilityCheckComplete { get; set; }

    /// <summary>
    /// The work queue that the appointment belongs to. It is not recommended to change this value manually via API. If status is NOT_READY, work_queue must be set. If status is READY or CHECKED_IN, work_queue must be null.
    /// </summary>
    [JsonPropertyName("work_queue")]
    public AppointmentWorkQueue? WorkQueue { get; set; }
}
