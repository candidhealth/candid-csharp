using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Contracts.V3;

[Serializable]
public record ContractServiceFacilityCreate
{
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

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
