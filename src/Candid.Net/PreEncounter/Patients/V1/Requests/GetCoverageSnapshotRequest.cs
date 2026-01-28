using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Patients.V1;

[Serializable]
public record GetCoverageSnapshotRequest
{
    [JsonIgnore]
    public DateTime? Date { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
