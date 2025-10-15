using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Notes.V1;

/// <summary>
/// A Note object with immutable server-owned properties.
/// </summary>
[Serializable]
public record Note : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// The organization that owns this object.
    /// </summary>
    [JsonPropertyName("organization_id")]
    public required string OrganizationId { get; set; }

    /// <summary>
    /// True if the object is deactivated.  Deactivated objects are not returned in search results but are returned in all other endpoints including scan.
    /// </summary>
    [JsonPropertyName("deactivated")]
    public required bool Deactivated { get; set; }

    /// <summary>
    /// The version of the object. Any update to any property of an object object will create a new version.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; set; }

    [JsonPropertyName("updated_at")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// The user ID of the user who last updated the object.
    /// </summary>
    [JsonPropertyName("updating_user_id")]
    public required string UpdatingUserId { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }

    [JsonPropertyName("author_email")]
    public string? AuthorEmail { get; set; }

    [JsonPropertyName("author_name")]
    public string? AuthorName { get; set; }

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
