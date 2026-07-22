using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Patients.V1;

[Serializable]
public record GetEligibilityTimelineRequest
{
    [JsonIgnore]
    public IEnumerable<EligibilityAuditEventType> EventTypes { get; set; } =
        new List<EligibilityAuditEventType>();

    [JsonIgnore]
    public string? CoverageId { get; set; }

    [JsonIgnore]
    public string? AppointmentId { get; set; }

    [JsonIgnore]
    public string? PageToken { get; set; }

    [JsonIgnore]
    public int? Limit { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
