using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Lists.V1;

[Serializable]
public record AppointmentsGetListRequest
{
    /// <summary>
    /// Defaults to appointment.startTimestamp.
    /// </summary>
    [JsonIgnore]
    public string? SortField { get; set; }

    /// <summary>
    /// Defaults to asc.
    /// </summary>
    [JsonIgnore]
    public global::Candid.Net.PreEncounter.Common.SortDirection? SortDirection { get; set; }

    /// <summary>
    /// Defaults to 100.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    [JsonIgnore]
    public string? PageToken { get; set; }

    [JsonIgnore]
    public string? Filters { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
