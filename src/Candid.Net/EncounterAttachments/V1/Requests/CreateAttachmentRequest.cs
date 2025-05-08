using Candid.Net.Core;

#nullable enable

namespace Candid.Net.EncounterAttachments.V1;

public record CreateAttachmentRequest
{
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
