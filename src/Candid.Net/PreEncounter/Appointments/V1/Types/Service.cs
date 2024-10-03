using System.Text.Json.Serialization;
using Candid.Net.Core;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
