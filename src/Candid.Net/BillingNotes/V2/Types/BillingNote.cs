using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.BillingNotes.V2;

[Serializable]
public record BillingNote : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("billing_note_id")]
    public required string BillingNoteId { get; set; }

    [JsonPropertyName("encounter_id")]
    public required string EncounterId { get; set; }

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
