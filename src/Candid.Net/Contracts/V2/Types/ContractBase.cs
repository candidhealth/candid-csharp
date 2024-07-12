using System.Text.Json.Serialization;
using Candid.Net.Contracts.V2;

#nullable enable

namespace Candid.Net.Contracts.V2;

public record ContractBase
{
    /// <summary>
    /// The starting day upon which the contract is effective
    /// </summary>
    [JsonPropertyName("effective_date")]
    public required string EffectiveDate { get; init; }

    /// <summary>
    /// An optional end day upon which the contract expires
    /// </summary>
    [JsonPropertyName("expiration_date")]
    public string? ExpirationDate { get; init; }

    /// <summary>
    /// The state(s) to which the contract's coverage extends.
    /// It may also be set to "national" for the entirety of the US.
    /// </summary>
    [JsonPropertyName("regions")]
    public required object Regions { get; init; }

    [JsonPropertyName("contract_status")]
    public ContractStatus? ContractStatus { get; init; }

    [JsonPropertyName("authorized_signatory")]
    public AuthorizedSignatory? AuthorizedSignatory { get; init; }

    /// <summary>
    /// The commercial plan insurance types this contract applies.
    /// </summary>
    [JsonPropertyName("commercial_insurance_types")]
    public required object CommercialInsuranceTypes { get; init; }

    /// <summary>
    /// The Medicare plan insurance types this contract applies.
    /// </summary>
    [JsonPropertyName("medicare_insurance_types")]
    public required object MedicareInsuranceTypes { get; init; }

    /// <summary>
    /// The Medicaid plan insurance types this contract applies.
    /// </summary>
    [JsonPropertyName("medicaid_insurance_types")]
    public required object MedicaidInsuranceTypes { get; init; }
}
