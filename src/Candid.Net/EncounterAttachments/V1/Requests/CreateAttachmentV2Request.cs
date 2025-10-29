using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.EncounterAttachments.V1;

[Serializable]
public record CreateAttachmentV2Request
{
    public required FileParameter AttachmentFile { get; set; }

    public required EncounterAttachmentType AttachmentType { get; set; }

    public string? Description { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
