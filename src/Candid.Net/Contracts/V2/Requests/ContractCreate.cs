using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Contracts.V2;

public record ContractCreate
{
    /// <summary>
    /// The UUID of the provider under agreement to the contract
    /// </summary>
    [JsonPropertyName("contracting_provider_id")]
    public required string ContractingProviderId { get; set; }

    /// <summary>
    /// A rendering provider isn't contracted directly with the payer but can render
    /// services under the contract held by the contracting provider.
    /// Max items is 1000.
    /// </summary>
    [JsonPropertyName("rendering_provider_ids")]
    public HashSet<string> RenderingProviderIds { get; set; } = new HashSet<string>();

    /// <summary>
    /// The UUID of the insurance company under agreement to the contract
    /// </summary>
    [JsonPropertyName("payer_uuid")]
    public required string PayerUuid { get; set; }

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
