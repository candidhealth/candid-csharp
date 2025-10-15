using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Appointments.V1;

[Serializable]
public record AppointmentScanRequest
{
    [JsonIgnore]
    public required DateTime Since { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
