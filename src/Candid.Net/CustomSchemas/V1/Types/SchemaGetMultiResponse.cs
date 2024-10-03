using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.CustomSchemas.V1;

public record SchemaGetMultiResponse
{
    [JsonPropertyName("schemas")]
    public IEnumerable<Schema> Schemas { get; set; } = new List<Schema>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
