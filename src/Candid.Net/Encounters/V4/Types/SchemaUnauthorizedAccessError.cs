using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record SchemaUnauthorizedAccessError
{
    [JsonPropertyName("schema_id")]
    public required string SchemaId { get; set; }
}
