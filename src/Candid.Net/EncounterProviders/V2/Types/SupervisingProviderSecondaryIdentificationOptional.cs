using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.EncounterProviders.V2;

[Serializable]
public record SupervisingProviderSecondaryIdentificationOptional : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("reference_identification")]
    public string? ReferenceIdentification { get; set; }

    [JsonPropertyName("reference_identification_qualifier")]
    public ProviderSecondaryIdentificationQualifier? ReferenceIdentificationQualifier { get; set; }

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
