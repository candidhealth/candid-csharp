using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record EncounterExternalIdUniquenessErrorType
{
    [JsonPropertyName("external_id")]
    public string? ExternalId { get; init; }
}
