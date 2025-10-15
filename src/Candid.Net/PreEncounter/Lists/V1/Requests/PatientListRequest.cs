using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Lists.V1;

[Serializable]
public record PatientListRequest
{
    [JsonIgnore]
    public string? PageToken { get; set; }

    [JsonIgnore]
    public int? Limit { get; set; }

    /// <summary>
    /// Defaults to patient.updatedAt.
    /// </summary>
    [JsonIgnore]
    public string? SortField { get; set; }

    /// <summary>
    /// Defaults to ascending.
    /// </summary>
    [JsonIgnore]
    public Candid.Net.PreEncounter.Common.SortDirection? SortDirection { get; set; }

    [JsonIgnore]
    public string? Filters { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
