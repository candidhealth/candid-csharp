using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Appointments.V1;

public record VisitsRequest
{
    public string? PageToken { get; set; }

    public int? Limit { get; set; }

    /// <summary>
    /// Defaults to appointment.start_time.
    /// </summary>
    public string? SortField { get; set; }

    /// <summary>
    /// Defaults to ascending.
    /// </summary>
    public Common.SortDirection? SortDirection { get; set; }

    public string? Filters { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
