using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Coverages.V1;

[Serializable]
public record ServiceCoverage : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("service_code")]
    public required ServiceTypeCode ServiceCode { get; set; }

    [JsonPropertyName("in_network")]
    public ServiceCoverageDetails? InNetwork { get; set; }

    [JsonPropertyName("in_network_flat")]
    public IEnumerable<CoverageDetails>? InNetworkFlat { get; set; }

    [JsonPropertyName("out_of_network")]
    public ServiceCoverageDetails? OutOfNetwork { get; set; }

    [JsonPropertyName("out_of_network_flat")]
    public IEnumerable<CoverageDetails>? OutOfNetworkFlat { get; set; }

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
