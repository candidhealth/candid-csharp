using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.PatientMerges.V1;

[Serializable]
public record PatientMergeScanRequest
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
