using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Images.V1;

public record CoverageAssociation
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("side")]
    public required CoverageImageSide Side { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
