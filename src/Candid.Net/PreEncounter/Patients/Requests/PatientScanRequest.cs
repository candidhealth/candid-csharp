namespace Candid.Net.PreEncounter;

public record PatientScanRequest
{
    public required DateTime Since { get; init; }
}
