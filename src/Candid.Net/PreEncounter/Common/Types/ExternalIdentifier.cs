using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter;

public record ExternalIdentifier
{
    [JsonPropertyName("value")]
    public required string Value { get; set; }

    [JsonPropertyName("system")]
    public required string System { get; set; }

    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
