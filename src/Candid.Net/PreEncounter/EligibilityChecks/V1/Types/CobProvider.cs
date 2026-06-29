using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// Information about the entity requesting the COB check.
/// Provide either organization_name (for organizations) or first_name and last_name (for individuals), plus npi.
/// </summary>
[Serializable]
public record CobProvider : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The provider's business name. Required if the provider is an organization.
    /// </summary>
    [JsonPropertyName("organization_name")]
    public string? OrganizationName { get; set; }

    /// <summary>
    /// The provider's first name. Required if the provider is an individual.
    /// </summary>
    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    /// <summary>
    /// The provider's last name. Required if the provider is an individual.
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    /// <summary>
    /// The provider's National Provider Identifier (NPI).
    /// </summary>
    [JsonPropertyName("npi")]
    public required string Npi { get; set; }

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
