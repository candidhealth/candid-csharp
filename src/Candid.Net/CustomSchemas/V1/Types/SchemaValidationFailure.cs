using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.CustomSchemas.V1;

public record SchemaValidationFailure
{
    [JsonPropertyName("errors")]
    public IEnumerable<object> Errors { get; set; } = new List<object>();
}
