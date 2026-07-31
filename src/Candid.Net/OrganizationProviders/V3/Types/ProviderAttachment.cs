using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.OrganizationProviders.V3;

[Serializable]
public record ProviderAttachment : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("provider_attachment_id")]
    public required string ProviderAttachmentId { get; set; }

    [JsonPropertyName("organization_provider_id")]
    public required string OrganizationProviderId { get; set; }

    [JsonPropertyName("file_name")]
    public required string FileName { get; set; }

    [JsonPropertyName("file_type")]
    public required ProviderAttachmentFileType FileType { get; set; }

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
