namespace Candid.Net.PreEncounter;

public record PatientsSearchRequest
{
    public string? NameContains { get; init; }
}
