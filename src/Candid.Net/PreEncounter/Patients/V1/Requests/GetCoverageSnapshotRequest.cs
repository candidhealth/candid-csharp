using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

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
