using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Guarantor.V1;

public record EncounterHasExistingGuarantorErrorType
{
    [JsonPropertyName("message")]
    public required string Message { get; init; }
}
