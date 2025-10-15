using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Images.V1;

[Serializable]
public record ImageGetMultiRequest
{
    [JsonIgnore]
    public string? PatientId { get; set; }

    [JsonIgnore]
    public string? CoverageId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
