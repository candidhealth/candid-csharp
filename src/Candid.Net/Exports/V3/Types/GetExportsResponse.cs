using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Exports.V3;

[Serializable]
public record GetExportsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Report name; contains date strings representing the start and end date of the export.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// Authenticated URL where a customer's report can be retrieved.
    /// </summary>
    [JsonPropertyName("authenticated_download_url")]
    public required string AuthenticatedDownloadUrl { get; set; }

    /// <summary>
    /// Expiration datetime of the authenticated URL. URLs expire after 2 minutes.
    /// </summary>
    [JsonPropertyName("authenticated_download_url_expiration")]
    public required DateTime AuthenticatedDownloadUrlExpiration { get; set; }

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
