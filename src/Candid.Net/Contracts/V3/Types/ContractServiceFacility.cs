using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Contracts.V3;

[Serializable]
public record ContractServiceFacility : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The UUID of the contract
    /// </summary>
    [JsonPropertyName("contract_id")]
    public required string ContractId { get; set; }

    [JsonPropertyName("contract_service_facility_id")]
    public required string ContractServiceFacilityId { get; set; }

    /// <summary>
    /// The UUID of the service facility
    /// </summary>
    [JsonPropertyName("service_facility_id")]
    public required string ServiceFacilityId { get; set; }

    /// <summary>
    /// The providers who are authorized under the contract
    /// </summary>
    [JsonPropertyName("provider_ids")]
    public HashSet<string> ProviderIds { get; set; } = new HashSet<string>();

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
