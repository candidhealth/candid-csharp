using System.Text.Json.Serialization;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter.Appointments.V1;

public record MutableAppointment
{
    /// <summary>
    /// The Candid-defined patient identifier.
    /// </summary>
    [JsonPropertyName("patient_id")]
    public required string PatientId { get; set; }

    /// <summary>
    /// True if the patient has checked in. Defaults to false.
    /// </summary>
    [JsonPropertyName("checked_in")]
    public bool? CheckedIn { get; set; }

    /// <summary>
    /// Patient’s initial assigned location or the location to which the patient is being moved. This location is stored on the Patient Demographics tab and is used when creating orders.
    /// </summary>
    [JsonPropertyName("assigned_patient_location")]
    public string? AssignedPatientLocation { get; set; }

    /// <summary>
    /// Attending physician information. The attending physician will be stored as the Current MD for the patient.
    /// </summary>
    [JsonPropertyName("attending_doctor")]
    public ExternalProvider? AttendingDoctor { get; set; }

    /// <summary>
    /// Referring physician information. The referring physician will be stored as the Referring MD in the patient’s Providers list.
    /// </summary>
    [JsonPropertyName("referring_doctor")]
    public ExternalProvider? ReferringDoctor { get; set; }

    [JsonPropertyName("start_timestamp")]
    public DateTime? StartTimestamp { get; set; }

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

    [JsonPropertyName("appointment_reason")]
    public AppointmentReason? AppointmentReason { get; set; }

    /// <summary>
    /// Contains the identifier code for the appointment.
    /// </summary>
    [JsonPropertyName("appointment_type")]
    public AppointmentType? AppointmentType { get; set; }

    /// <summary>
    /// Contains the coded identification of the location being scheduled. Components: <Identifier (ST)>^<Text (ST)>
    /// </summary>
    [JsonPropertyName("location_resource_id")]
    public string? LocationResourceId { get; set; }

    /// <summary>
    /// The work queue that the appointment belongs to. It is not recommended to change this value manually via API.
    /// </summary>
    [JsonPropertyName("work_queue")]
    public AppointmentWorkQueue? WorkQueue { get; set; }
}
