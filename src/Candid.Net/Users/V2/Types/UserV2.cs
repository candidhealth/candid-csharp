using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Users.V2;

[Serializable]
public record UserV2 : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("user_id")]
    public required string UserId { get; set; }

    [JsonPropertyName("idp_metadata")]
    public IEnumerable<IdpUserMetadata> IdpMetadata { get; set; } = new List<IdpUserMetadata>();

    [JsonPropertyName("primary_organization_id")]
    public string? PrimaryOrganizationId { get; set; }

    [JsonPropertyName("user_metadata")]
    public required UserMetadata UserMetadata { get; set; }

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
