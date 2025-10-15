using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Coverages.V1;

[Serializable]
public record CoverageGetMultiRequest
{
    [JsonIgnore]
    public string? PatientId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
