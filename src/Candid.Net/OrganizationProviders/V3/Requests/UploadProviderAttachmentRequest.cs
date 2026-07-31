using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.OrganizationProviders.V3;

[Serializable]
public record UploadProviderAttachmentRequest
{
    public required FileParameter AttachmentFile { get; set; }

    public required ProviderAttachmentFileType FileType { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
