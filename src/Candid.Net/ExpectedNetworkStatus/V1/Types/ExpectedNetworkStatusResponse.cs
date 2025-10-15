using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.ExpectedNetworkStatus.V1;

[Serializable]
public record ExpectedNetworkStatusResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The anticipated classification of a healthcare provider within the insurance plan's network.
    /// </summary>
    [JsonPropertyName("expected_network_status")]
    public required ExpectedNetworkStatus ExpectedNetworkStatus { get; set; }

    [JsonPropertyName("explanation")]
    public required string Explanation { get; set; }

    [JsonPropertyName("contract_id")]
    public string? ContractId { get; set; }

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
