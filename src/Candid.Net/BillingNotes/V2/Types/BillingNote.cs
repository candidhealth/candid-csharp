using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.BillingNotes.V2;

public record BillingNote
{
    [JsonPropertyName("billing_note_id")]
    public required Guid BillingNoteId { get; init; }

    [JsonPropertyName("encounter_id")]
    public required Guid EncounterId { get; init; }

    /// <summary>
    /// An [RFC 3339, section 5.6 datetime](https://ijmacd.github.io/rfc3339-iso8601/).
    /// For example, 2017-07-21T17:32:28Z.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; init; }

    [JsonPropertyName("author_auth0_id")]
    public string? AuthorAuth0Id { get; init; }

    [JsonPropertyName("author_name")]
    public string? AuthorName { get; init; }

    /// <summary>
    /// Empty string not allowed.
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; init; }
}
