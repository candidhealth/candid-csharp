using System.Text.Json.Serialization;
using Candid.Net.OrganizationProviders.V2;
using Candid.Net.Payers.V3;

#nullable enable

namespace Candid.Net.Contracts.V2;

public record Contract
{
    [JsonPropertyName("contract_id")]
    public required string ContractId { get; set; }

    /// <summary>
    /// The provider under contract
    /// </summary>
    [JsonPropertyName("contracting_provider")]
    public required OrganizationProvider ContractingProvider { get; set; }

    /// <summary>
    /// The number of linked providers who can render medical services under this contract
    /// </summary>
    [JsonPropertyName("provider_count")]
    public required int ProviderCount { get; set; }

    /// <summary>
    /// The insurance company under contract
    /// </summary>
    [JsonPropertyName("payer")]
    public required Payer Payer { get; set; }
}
