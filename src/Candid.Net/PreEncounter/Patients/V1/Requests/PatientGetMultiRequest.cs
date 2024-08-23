namespace Candid.Net.PreEncounter.Patients.V1;

public record PatientGetMultiRequest
{
    public string? Mrn { get; set; }

    /// <summary>
    /// A string that is used to order similar names in search results.
    /// </summary>
    public string? SimilarNameOrdering { get; set; }
}
