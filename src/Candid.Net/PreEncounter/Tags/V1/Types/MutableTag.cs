using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Tags.V1;

public record MutableTag
{
    [JsonPropertyName("value")]
    public required string Value { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("alert")]
    public bool? Alert { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
