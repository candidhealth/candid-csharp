using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public record PatientGetMultiRequest
{
    public string? Mrn { get; set; }

    /// <summary>
    /// A string that is used to order similar names in search results.
    /// </summary>
    public string? SimilarNameOrdering { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
