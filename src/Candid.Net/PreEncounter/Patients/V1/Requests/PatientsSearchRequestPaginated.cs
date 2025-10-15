using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Patients.V1;

[Serializable]
public record PatientsSearchRequestPaginated
{
    [JsonIgnore]
    public int? Limit { get; set; }

    [JsonIgnore]
    public string? Mrn { get; set; }

    [JsonIgnore]
    public string? PageToken { get; set; }

    [JsonIgnore]
    public string? SortField { get; set; }

    /// <summary>
    /// Defaults to ascending.
    /// </summary>
    [JsonIgnore]
    public Candid.Net.PreEncounter.Common.SortDirection? SortDirection { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
