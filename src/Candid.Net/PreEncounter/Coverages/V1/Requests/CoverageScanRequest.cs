namespace Candid.Net.PreEncounter.Coverages.V1;

public record CoverageScanRequest
{
    public required DateTime Since { get; set; }
}
