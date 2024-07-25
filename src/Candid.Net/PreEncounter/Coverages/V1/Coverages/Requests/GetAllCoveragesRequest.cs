namespace Candid.Net.PreEncounter.Coverages.V1;

public record GetAllCoveragesRequest
{
    public string? PatientId { get; init; }
}
