using System.Text.Json.Serialization;
using Candid.Net.Core;

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
    public Candid.Net.PreEncounter.Common.SortDirection? SortDirection { get; set; }

    [JsonIgnore]
    public string? Filters { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
