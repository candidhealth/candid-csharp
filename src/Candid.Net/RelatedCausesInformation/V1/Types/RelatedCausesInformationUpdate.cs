using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.RelatedCausesInformation.V1;

[Serializable]
public record RelatedCausesInformationUpdate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("related_causes_code_1")]
    public required RelatedCausesCode RelatedCausesCode1 { get; set; }

    [JsonPropertyName("related_causes_code_2")]
    public RelatedCausesCode? RelatedCausesCode2 { get; set; }

    [JsonPropertyName("state_or_province_code")]
    public string? StateOrProvinceCode { get; set; }

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
