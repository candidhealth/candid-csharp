using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record EntityConflictErrorMessage
{
    [JsonPropertyName("entity_name")]
    public required string EntityName { get; set; }
}
