using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// Information about the entity that submitted the original COB request.
/// </summary>
[Serializable]
public record CobResponseProvider : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The provider's last name. Applies to providers that are an individual.
    /// </summary>
    [JsonPropertyName("provider_name")]
    public string? ProviderName { get; set; }

    /// <summary>
    /// The provider's first name. Applies to providers that are an individual.
    /// </summary>
    [JsonPropertyName("provider_first_name")]
    public string? ProviderFirstName { get; set; }

    /// <summary>
    /// The provider's organization name.
    /// </summary>
    [JsonPropertyName("provider_org_name")]
    public string? ProviderOrgName { get; set; }

    /// <summary>
    /// The provider's National Provider Identifier (NPI).
    /// </summary>
    [JsonPropertyName("npi")]
    public string? Npi { get; set; }

    /// <summary>
    /// AAA errors specifying reasons for rejection and recommended follow-up actions.
    /// </summary>
    [JsonPropertyName("aaa_errors")]
    public IEnumerable<EligibilityCheckErrorDetails>? AaaErrors { get; set; }

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
