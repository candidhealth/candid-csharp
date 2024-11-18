using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public record CreatePatientWithMrnRequest
{
    public bool? SkipDuplicateCheck { get; set; }

    public required MutablePatientWithMrn Body { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
