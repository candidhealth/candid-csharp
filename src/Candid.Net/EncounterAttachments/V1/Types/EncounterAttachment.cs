using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.Users.V2;

namespace Candid.Net.EncounterAttachments.V1;

[Serializable]
public record EncounterAttachment : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("encounter_id")]
    public required string EncounterId { get; set; }

    [JsonPropertyName("attachment_type")]
    public required EncounterAttachmentType AttachmentType { get; set; }

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("created_by")]
    public required UserV2 CreatedBy { get; set; }

    [JsonPropertyName("attachment_id")]
    public required string AttachmentId { get; set; }

    [JsonPropertyName("file_name")]
    public required string FileName { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("content_type")]
    public required string ContentType { get; set; }

    [JsonPropertyName("authed_url")]
    public required string AuthedUrl { get; set; }

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
