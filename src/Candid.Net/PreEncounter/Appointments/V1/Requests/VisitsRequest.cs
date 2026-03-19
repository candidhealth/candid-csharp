using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.Appointments.V1;

[Serializable]
public record VisitsRequest
{
    [JsonIgnore]
    public string? PageToken { get; set; }

    [JsonIgnore]
    public int? Limit { get; set; }

    /// <summary>
    /// Defaults to appointment.start_time.
    /// </summary>
    [JsonIgnore]
    public string? SortField { get; set; }

    /// <summary>
    /// Defaults to ascending.
    /// </summary>
    [JsonIgnore]
    public global::Candid.Net.PreEncounter.Common.SortDirection? SortDirection { get; set; }

    /// <summary>
    /// **Required:** Must include a date filter on appointment.startTimestamp (using gt, lt, or eq operators).
    /// Example: appointment.startTimestamp|gt|2024-01-01
    /// </summary>
    [JsonIgnore]
    public string? Filters { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
