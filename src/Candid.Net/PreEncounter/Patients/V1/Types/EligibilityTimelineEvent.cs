using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Patients.V1;

/// <summary>
/// A single eligibility audit event.
/// </summary>
[Serializable]
public record EligibilityTimelineEvent : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("event_type")]
    public required EligibilityAuditEventType EventType { get; set; }

    [JsonPropertyName("patient_id")]
    public required string PatientId { get; set; }

    [JsonPropertyName("coverage_id")]
    public string? CoverageId { get; set; }

    [JsonPropertyName("appointment_id")]
    public string? AppointmentId { get; set; }

    [JsonPropertyName("appointment_date")]
    public DateTime? AppointmentDate { get; set; }

    [JsonPropertyName("timestamp")]
    public required DateTime Timestamp { get; set; }

    [JsonPropertyName("user_id")]
    public required string UserId { get; set; }

    /// <summary>
    /// Actor display name; "Candid Health" for automated writes.
    /// </summary>
    [JsonPropertyName("user_name")]
    public required string UserName { get; set; }

    /// <summary>
    /// Event-type-specific payload.
    /// </summary>
    [JsonPropertyName("payload")]
    public Dictionary<string, object?> Payload { get; set; } = new Dictionary<string, object?>();

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
