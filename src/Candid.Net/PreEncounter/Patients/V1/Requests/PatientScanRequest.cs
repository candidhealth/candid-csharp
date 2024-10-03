using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public record PatientScanRequest
{
    public required DateTime Since { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
