using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Common;

public record ContactPoint
{
    [JsonPropertyName("value")]
    public required string Value { get; set; }

    [JsonPropertyName("use")]
    public required ContactPointUse Use { get; set; }

    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
