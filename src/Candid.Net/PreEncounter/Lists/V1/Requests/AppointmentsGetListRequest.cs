using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Lists.V1;

public record AppointmentsGetListRequest
{
    /// <summary>
    /// Defaults to appointment.startTimestamp.
    /// </summary>
    public string? SortField { get; set; }

    /// <summary>
    /// Defaults to asc.
    /// </summary>
    public SortDirection? SortDirection { get; set; }

    /// <summary>
    /// Defaults to 100.
    /// </summary>
    public int? Limit { get; set; }

    public string? PageToken { get; set; }

    public string? Filters { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
