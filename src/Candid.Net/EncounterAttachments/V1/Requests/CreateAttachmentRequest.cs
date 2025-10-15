using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.EncounterAttachments.V1;

[Serializable]
public record CreateAttachmentRequest
{
    public required FileParameter AttachmentFile { get; set; }

    public required EncounterAttachmentType AttachmentType { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
