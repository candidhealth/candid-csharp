using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Coverages.V1;

[Serializable]
public record GetInsuranceDiscoveryCheckMetadataRequest
{
    [JsonIgnore]
    public required string PatientId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
