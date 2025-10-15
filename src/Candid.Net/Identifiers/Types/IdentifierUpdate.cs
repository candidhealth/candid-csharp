using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.Identifiers;

[Serializable]
public record IdentifierUpdate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("identifier_id")]
    public required string IdentifierId { get; set; }

    [JsonPropertyName("identifier_code")]
    public IdentifierCode? IdentifierCode { get; set; }

    [JsonPropertyName("identifier_value")]
    public IdentifierValue? IdentifierValue { get; set; }

    [JsonPropertyName("period")]
    public RemovableDateRangeOptionalEnd? Period { get; set; }

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
