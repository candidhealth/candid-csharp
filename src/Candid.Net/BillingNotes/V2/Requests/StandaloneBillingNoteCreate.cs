using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.BillingNotes.V2;

public record StandaloneBillingNoteCreate
{
    [JsonPropertyName("encounter_id")]
    public required string EncounterId { get; set; }

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
