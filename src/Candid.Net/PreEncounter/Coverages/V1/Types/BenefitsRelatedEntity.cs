using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Coverages.V1;

[Serializable]
public record BenefitsRelatedEntity : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("entityIdentifier")]
    public string? EntityIdentifier { get; set; }

    [JsonPropertyName("entityType")]
    public string? EntityType { get; set; }

    [JsonPropertyName("entityName")]
    public string? EntityName { get; set; }

    [JsonPropertyName("contactInformation")]
    public IEnumerable<RelatedEntityContact>? ContactInformation { get; set; }

    [JsonPropertyName("serviceTypeCodes")]
    public IEnumerable<ServiceTypeCode>? ServiceTypeCodes { get; set; }

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
