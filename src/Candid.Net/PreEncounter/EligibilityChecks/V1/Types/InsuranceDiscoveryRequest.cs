using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// An object representing the data for an insurance discovery request.
/// </summary>
[Serializable]
public record InsuranceDiscoveryRequest : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("provider")]
    public required InsuranceDiscoveryProvider Provider { get; set; }

    [JsonPropertyName("subscriber")]
    public required InsuranceDiscoverySubscriber Subscriber { get; set; }

    [JsonPropertyName("dependent")]
    public InsuranceDiscoveryDependent? Dependent { get; set; }

    [JsonPropertyName("encounter")]
    public InsuranceDiscoveryEncounter? Encounter { get; set; }

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
