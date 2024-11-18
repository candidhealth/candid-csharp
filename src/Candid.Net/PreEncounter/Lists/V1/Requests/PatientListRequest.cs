using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Lists.V1;

public record PatientListRequest
{
    public string? PageToken { get; set; }

    public int? Limit { get; set; }

    /// <summary>
    /// Defaults to patient.updatedAt.
    /// </summary>
    public string? SortField { get; set; }

    /// <summary>
    /// Defaults to ascending.
    /// </summary>
    public SortDirection? SortDirection { get; set; }

    public string? Filters { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
