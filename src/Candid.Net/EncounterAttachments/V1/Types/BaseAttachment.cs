using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.EncounterAttachments.V1;

public record BaseAttachment
{
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
