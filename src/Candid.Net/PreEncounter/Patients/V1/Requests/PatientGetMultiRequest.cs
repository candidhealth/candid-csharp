using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Patients.V1;

[Serializable]
public record PatientGetMultiRequest
{
    [JsonIgnore]
    public string? Mrn { get; set; }

    /// <summary>
    /// A string that is used to order similar names in search results.
    /// </summary>
    [JsonIgnore]
    public string? SimilarNameOrdering { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
