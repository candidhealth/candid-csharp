using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.BillingNotes.V2;

public record StandaloneBillingNoteCreate
{
    [JsonPropertyName("encounter_id")]
    public required Guid EncounterId { get; init; }
}
