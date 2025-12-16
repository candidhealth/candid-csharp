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
    ///
    /// | Event Type | Description |
    /// |------------|-------------|
    /// | `CandidApi.Encounter.Created` | When a new claim is created |
    /// | `CandidApi.Encounter.StatusUpdated` | When a claim's status has been updated |
    /// | `PreEncounter.Patient.Created` | When a new patient has been created |
    /// | `PreEncounter.Patient.Updated` | When a patient's information has been updated |
    /// | `PreEncounter.Coverage.Created` | When a new coverage has been created for a patient |
    /// | `PreEncounter.Coverage.Updated` | When a patient's coverage has been updated |
    /// | `PreEncounter.Tag.Created` | When a new tag has been created for a patient |
    /// | `PreEncounter.Tag.Updated` | When a patient's tag has been updated |
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
