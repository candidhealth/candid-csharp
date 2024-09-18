namespace Candid.Net.PreEncounter.Lists.V1;

public record PatientListRequest
{
    public string? PageToken { get; set; }

    public int? Limit { get; set; }

    public string? SortField { get; set; }

    /// <summary>
    /// Defaults to ascending.
    /// </summary>
    public SortDirection? SortDirection { get; set; }

    public string? Filters { get; set; }
}
