using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

namespace Candid.Net.OrganizationProviders.V3;

[Serializable]
public record DownloadProviderAttachmentRequest
{
    [JsonIgnore]
    public required string AttachmentId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
