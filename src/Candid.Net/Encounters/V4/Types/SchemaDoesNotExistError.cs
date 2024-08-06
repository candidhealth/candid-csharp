using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record SchemaDoesNotExistError
{
    [JsonPropertyName("schema_id")]
    public required string SchemaId { get; set; }
}
