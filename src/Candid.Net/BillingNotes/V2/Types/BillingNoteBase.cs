using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.BillingNotes.V2;

public record BillingNoteBase
{
    /// <summary>
    /// Empty string not allowed.
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; set; }
}
