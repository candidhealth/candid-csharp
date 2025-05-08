using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.EncounterAttachments.V1;

public record DeleteAttachmentRequest
{
    [JsonPropertyName("attachment_id")]
    public required string AttachmentId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
