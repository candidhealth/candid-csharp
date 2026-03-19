using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net;
using global::Candid.Net.Commons;
using global::Candid.Net.Core;

namespace Candid.Net.Identifiers;

[Serializable]
public record Identifier : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("identifier_id")]
    public required string IdentifierId { get; set; }

    [JsonPropertyName("period")]
    public DateRangeOptionalEnd? Period { get; set; }

    [JsonPropertyName("identifier_code")]
    public required IdentifierCode IdentifierCode { get; set; }

    [JsonPropertyName("identifier_value")]
    public required IdentifierValue IdentifierValue { get; set; }

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
