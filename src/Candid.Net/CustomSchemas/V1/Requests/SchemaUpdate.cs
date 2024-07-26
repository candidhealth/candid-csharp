using System.Text.Json.Serialization;
using Candid.Net.CustomSchemas.V1;

#nullable enable

namespace Candid.Net.CustomSchemas.V1;

public record SchemaUpdate
{
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// A list of typed entries to add to schema. Only additive modifications are permitted.
    /// </summary>
    [JsonPropertyName("fields_to_add")]
    public IEnumerable<SchemaField>? FieldsToAdd { get; init; }
}
