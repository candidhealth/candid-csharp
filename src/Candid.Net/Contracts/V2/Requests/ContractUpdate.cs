using System.Text.Json.Serialization;
using Candid.Net.Contracts.V2;

#nullable enable

namespace Candid.Net.Contracts.V2;

public record ContractUpdate
{
    /// <summary>
    /// A rendering provider isn't contracted directly with the payer but can render
    /// services under the contract held by the contracting provider.
    /// Max items is 100.
    ///
    /// </summary>
    [JsonPropertyName("rendering_provider_ids")]
    public HashSet<string>? RenderingProviderIds { get; set; }

    /// <summary>
    /// The starting day upon which the contract is effective
    /// </summary>
    [JsonPropertyName("effective_date")]
    public string? EffectiveDate { get; set; }

    /// <summary>
    /// An optional end day upon which the contract expires
    /// </summary>
    [JsonPropertyName("expiration_date")]
    public object? ExpirationDate { get; set; }

    /// <summary>
    /// If present, the contract's rendering providers will be patched to this exact
    /// value, overriding what was set before.
    ///
    /// </summary>
    [JsonPropertyName("regions")]
    public object? Regions { get; set; }

    [JsonPropertyName("contract_status")]
    public ContractStatus? ContractStatus { get; set; }

    [JsonPropertyName("authorized_signatory")]
    public object? AuthorizedSignatory { get; set; }

    [JsonPropertyName("commercial_insurance_types")]
    public object? CommercialInsuranceTypes { get; set; }

    [JsonPropertyName("medicare_insurance_types")]
    public object? MedicareInsuranceTypes { get; set; }

    [JsonPropertyName("medicaid_insurance_types")]
    public object? MedicaidInsuranceTypes { get; set; }
}
