using System.Text.Json.Serialization;
using Candid.Net.Core;
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

    /// <summary>
    /// The starting day upon which the contract is effective
    /// </summary>
    [JsonPropertyName("effective_date")]
    public required string EffectiveDate { get; set; }

    /// <summary>
    /// An optional end day upon which the contract expires
    /// </summary>
    [JsonPropertyName("expiration_date")]
    public string? ExpirationDate { get; set; }

    /// <summary>
    /// The state(s) to which the contract's coverage extends.
    /// It may also be set to "national" for the entirety of the US.
    /// </summary>
    [JsonPropertyName("regions")]
    public required object Regions { get; set; }

    [JsonPropertyName("contract_status")]
    public ContractStatus? ContractStatus { get; set; }

    [JsonPropertyName("authorized_signatory")]
    public AuthorizedSignatory? AuthorizedSignatory { get; set; }

    /// <summary>
    /// The commercial plan insurance types this contract applies.
    /// </summary>
    [JsonPropertyName("commercial_insurance_types")]
    public required object CommercialInsuranceTypes { get; set; }

    /// <summary>
    /// The Medicare plan insurance types this contract applies.
    /// </summary>
    [JsonPropertyName("medicare_insurance_types")]
    public required object MedicareInsuranceTypes { get; set; }

    /// <summary>
    /// The Medicaid plan insurance types this contract applies.
    /// </summary>
    [JsonPropertyName("medicaid_insurance_types")]
    public required object MedicaidInsuranceTypes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
