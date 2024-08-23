using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter.Appointments.V1;

public record Service
{
    /// <summary>
    /// Contains the code describing the activity type that is being scheduled.
    /// </summary>
    [JsonPropertyName("universal_service_identifier")]
    public UniversalServiceIdentifier? UniversalServiceIdentifier { get; set; }

    [JsonPropertyName("start_timestamp")]
    public DateTime? StartTimestamp { get; set; }
}
