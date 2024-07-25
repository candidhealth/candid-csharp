namespace Candid.Net.PreEncounter.Patients.V1;

public record PatientsSearchRequest
{
    public string? NameContains { get; init; }
}
