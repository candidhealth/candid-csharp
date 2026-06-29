using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EncounterAttachments.V1;

[Serializable]
public record DeleteAttachmentRequest
{
    [JsonPropertyName("attachment_id")]
    public required string AttachmentId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
