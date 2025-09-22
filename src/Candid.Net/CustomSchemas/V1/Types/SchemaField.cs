using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.CustomSchemas.V1;

public record SchemaField
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("type")]
    public required Primitive Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
