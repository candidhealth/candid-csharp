using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

namespace Candid.Net.BillingNotes.V2;

[Serializable]
public record StandaloneBillingNoteCreate
{
    [JsonPropertyName("encounter_id")]
    public required string EncounterId { get; set; }

    /// <summary>
    /// Empty string not allowed.
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
