using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Patients.V1;

[Serializable]
public record CreatePatientRequest
{
    [JsonIgnore]
    public bool? SkipDuplicateCheck { get; set; }

    [JsonIgnore]
    public required MutablePatient Body { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
