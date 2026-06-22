using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Appointments.V1;

[Serializable]
public record CountsRequest
{
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
