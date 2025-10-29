using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Patients.V1;

[Serializable]
public record PatientScanRequest
{
    [JsonIgnore]
    public required DateTime Since { get; set; }

    [JsonIgnore]
    public int? MaxResults { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
