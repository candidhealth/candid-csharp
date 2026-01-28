using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Coverages.V1;

[Serializable]
public record CoveragesGetHistoryRequest
{
    [JsonIgnore]
    public DateOnly? Start { get; set; }

    [JsonIgnore]
    public DateOnly? End { get; set; }

    /// <summary>
    /// If true, only returns coverages that have NOT been auto-updated by the system.
    /// </summary>
    [JsonIgnore]
    public bool? NonAutoUpdatedCoveragesOnly { get; set; }

    /// <summary>
    /// Defaults to ascending. Sorts by version.
    /// </summary>
    [JsonIgnore]
    public global::Candid.Net.PreEncounter.Common.SortDirection? SortDirection { get; set; }

    /// <summary>
    /// Must be between 0 and 1000. No default.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
