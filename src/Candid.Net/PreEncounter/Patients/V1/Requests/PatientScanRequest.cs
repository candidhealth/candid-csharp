namespace Candid.Net.PreEncounter.Patients.V1;

public record PatientScanRequest
{
    public required DateTime Since { get; set; }
}
