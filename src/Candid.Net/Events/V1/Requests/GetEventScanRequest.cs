using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Events.V1;

[Serializable]
public record GetEventScanRequest
{
    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <summary>
    /// Number of events to return. Minimum value is 1, maximum is 100. Defaults to 10.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    /// <summary>
    /// Event types to filter on. Defaults to showing all event types.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> EventTypes { get; set; } = new List<string>();

    /// <summary>
    /// Filters for only events created before this time (inclusive).
    /// </summary>
    [JsonIgnore]
    public DateTime? CreatedBefore { get; set; }

    /// <summary>
    /// Filters for only events created after this time (inclusive).
    /// </summary>
    [JsonIgnore]
    public DateTime? CreatedAfter { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
