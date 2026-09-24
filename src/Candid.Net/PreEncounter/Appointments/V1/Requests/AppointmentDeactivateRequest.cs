using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Appointments.V1;

[Serializable]
public record AppointmentDeactivateRequest
{
    /// <summary>
    /// The reason the appointment is being cancelled.
    /// </summary>
    [JsonIgnore]
    public string? CancellationReason { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
