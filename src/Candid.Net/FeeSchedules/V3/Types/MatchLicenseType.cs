using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.OrganizationProviders.V2;

namespace Candid.Net.FeeSchedules.V3;

/// <summary>
/// Match information for rendering provider license type
/// </summary>
[Serializable]
public record MatchLicenseType : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("value")]
    public LicenseType? Value { get; set; }

    [JsonPropertyName("match")]
    public required bool Match { get; set; }

    [JsonPropertyName("explanation")]
    public required string Explanation { get; set; }

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
