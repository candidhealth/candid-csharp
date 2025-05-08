using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.BillingNotes.V2;

public record BillingNoteOptional
{
    [JsonPropertyName("billing_note_id")]
    public required string BillingNoteId { get; set; }

    [JsonPropertyName("encounter_id")]
    public string? EncounterId { get; set; }

    /// <summary>
    /// An [RFC 3339, section 5.6 datetime](https://ijmacd.github.io/rfc3339-iso8601/).
    /// For example, 2017-07-21T17:32:28Z.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("author_auth0_id")]
    public string? AuthorAuth0Id { get; set; }

    [JsonPropertyName("author_name")]
    public string? AuthorName { get; set; }

    /// <summary>
    /// Empty string not allowed.
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
