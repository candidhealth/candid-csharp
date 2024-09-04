namespace Candid.Net.PreEncounter.Patients.V1;

public record PatientsSearchRequestPaginated
{
    public int? Limit { get; set; }

    public string? Mrn { get; set; }

    public string? PageToken { get; set; }

    public string? SortField { get; set; }

    /// <summary>
    /// Defaults to ascending.
    /// </summary>
    public SortDirection? SortDirection { get; set; }
}
