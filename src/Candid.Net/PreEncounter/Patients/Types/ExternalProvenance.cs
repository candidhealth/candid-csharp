using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter;

public record ExternalProvenance
{
    [JsonPropertyName("externalId")]
    public required string ExternalId { get; init; }

    [JsonPropertyName("systemName")]
    public required string SystemName { get; init; }
}
