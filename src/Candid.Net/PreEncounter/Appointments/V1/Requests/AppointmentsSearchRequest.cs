namespace Candid.Net.PreEncounter.Appointments.V1;

public record AppointmentsSearchRequest
{
    public bool? CheckedIn { get; set; }

    public string? PatientId { get; set; }

    public DateTime? MinStartTimestamp { get; set; }

    public DateTime? MaxStartTimestamp { get; set; }

    public string? PlacerAppointmentId { get; set; }

    public AppointmentWorkQueue? WorkQueue { get; set; }

    /// <summary>
    /// Defaults to start_timestamp.
    /// </summary>
    public AppointmentSortField? SortField { get; set; }

    /// <summary>
    /// Defaults to asc.
    /// </summary>
    public SortDirection? SortDirection { get; set; }

    /// <summary>
    /// Defaults to 1000.
    /// </summary>
    public int? Limit { get; set; }
}
