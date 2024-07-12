namespace Candid.Net.PreEncounter;

public record CoverageScanRequest
{
    public required DateTime Since { get; init; }
}
