using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Contracts.V3;

[Serializable]
public record AddContractProvidersResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The total number of rendering providers currently associated with this contract after the operation
    /// </summary>
    [JsonPropertyName("provider_count")]
    public required int ProviderCount { get; set; }

    /// <summary>
    /// The number of rendering providers that were newly added to the contract
    /// </summary>
    [JsonPropertyName("added_count")]
    public required int AddedCount { get; set; }

    /// <summary>
    /// The number of rendering provider IDs that were already associated with the contract and thus ignored
    /// </summary>
    [JsonPropertyName("ignored_count")]
    public required int IgnoredCount { get; set; }

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
