using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Patients.V1;

[Serializable]
public record CreatePatientWithMrnRequest
{
    [JsonIgnore]
    public bool? SkipDuplicateCheck { get; set; }

    [JsonIgnore]
    public required MutablePatientWithMrn Body { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
