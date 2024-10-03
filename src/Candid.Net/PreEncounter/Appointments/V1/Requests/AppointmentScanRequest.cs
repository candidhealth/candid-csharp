using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Appointments.V1;

public record AppointmentScanRequest
{
    public required DateTime Since { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
