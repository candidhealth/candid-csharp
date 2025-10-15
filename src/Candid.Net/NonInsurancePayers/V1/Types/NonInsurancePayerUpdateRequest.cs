using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.NonInsurancePayers.V1;

[Serializable]
public record NonInsurancePayerUpdateRequest : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Max 50 characters allowed
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("description")]
    public NonInsurancePayerDescriptionUpdate? Description { get; set; }

    [JsonPropertyName("category")]
    public NonInsurancePayerCategoryUpdate? Category { get; set; }

    [JsonPropertyName("address")]
    public NonInsurancePayerAddressUpdate? Address { get; set; }

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
