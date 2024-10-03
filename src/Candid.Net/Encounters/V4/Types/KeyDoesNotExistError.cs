using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record KeyDoesNotExistError
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("schema_id")]
    public required string SchemaId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
