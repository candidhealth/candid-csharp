using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Common;

[Serializable]
public record ExternalProvider : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("name")]
    public required HumanName Name { get; set; }

    /// <summary>
    /// Defaults to ATTENDING.
    /// </summary>
    [JsonPropertyName("type")]
    public ExternalProviderType? Type { get; set; }

    [JsonPropertyName("npi")]
    public string? Npi { get; set; }

    [JsonPropertyName("telecoms")]
    public IEnumerable<ContactPoint> Telecoms { get; set; } = new List<ContactPoint>();

    [JsonPropertyName("addresses")]
    public IEnumerable<Address>? Addresses { get; set; }

    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    [JsonPropertyName("canonical_id")]
    public string? CanonicalId { get; set; }

    [JsonPropertyName("fax")]
    public string? Fax { get; set; }

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
