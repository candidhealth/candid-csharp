using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Exports.V3;

public record GetExportsRequest
{
    /// <summary>
    /// Beginning date of claim versions returned in the export, ISO 8601 date e.g. 2019-08-24.
    /// Must be at least 1 calendar day in the past. Cannot be earlier than 2022-10-07.
    /// </summary>
    public required DateOnly StartDate { get; set; }

    /// <summary>
    /// Ending date of claim versions returned in the export, ISO 8601 date; e.g. 2019-08-24.
    /// Must be within 30 days of start_date.
    /// </summary>
    public required DateOnly EndDate { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
