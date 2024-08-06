using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record SchemaInstanceValidationFailure
{
    [JsonPropertyName("errors")]
    public IEnumerable<object> Errors { get; set; } = new List<object>();
}
