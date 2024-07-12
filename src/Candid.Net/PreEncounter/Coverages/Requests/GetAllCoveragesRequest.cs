namespace Candid.Net.PreEncounter;

public record GetAllCoveragesRequest
{
    public string? PatientId { get; init; }
}
