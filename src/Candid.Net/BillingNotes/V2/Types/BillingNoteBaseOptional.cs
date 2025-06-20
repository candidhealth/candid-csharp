using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.BillingNotes.V2;

public record BillingNoteBaseOptional
{
    /// <summary>
    /// Empty string not allowed.
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
