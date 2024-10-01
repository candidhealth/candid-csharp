namespace Candid.Net.PreEncounter.Appointments.V1;

public record AppointmentScanRequest
{
    public required DateTime Since { get; set; }
}
