using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Common;

[Serializable]
public record Address : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("use")]
    public required AddressUse Use { get; set; }

    [JsonPropertyName("line")]
    public IEnumerable<string> Line { get; set; } = new List<string>();

    [JsonPropertyName("city")]
    public required string City { get; set; }

    [JsonPropertyName("state")]
    public required string State { get; set; }

    /// <summary>
    /// The top-level administrative subdivision of the country for addresses outside the US — for example a Canadian province, a UK county, or a Japanese prefecture. Only permitted on international addresses: `country` must be present and non-US, and `state` must be "FC" (the X12 foreign-country sentinel). For US addresses use `state` instead.
    /// </summary>
    [JsonPropertyName("administrative_area")]
    public string? AdministrativeArea { get; set; }

    [JsonPropertyName("postal_code")]
    public required string PostalCode { get; set; }

    [JsonPropertyName("country")]
    public required string Country { get; set; }

    [JsonPropertyName("county")]
    public string? County { get; set; }

    [JsonPropertyName("period")]
    public Period? Period { get; set; }

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
