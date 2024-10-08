using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.CustomSchemas.V1;

public record SchemaUpdate
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// A list of typed entries to add to schema. Only additive modifications are permitted.
    /// </summary>
    [JsonPropertyName("fields_to_add")]
    public IEnumerable<SchemaField>? FieldsToAdd { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
