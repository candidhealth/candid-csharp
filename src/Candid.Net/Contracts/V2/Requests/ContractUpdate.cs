using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Contracts.V2;

[Serializable]
public record ContractUpdate
{
    /// <summary>
    /// A rendering provider isn't contracted directly with the payer but can render
    /// services under the contract held by the contracting provider.
    /// Max items is 4000.
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
    public DateUpdate? ExpirationDate { get; set; }

    /// <summary>
    /// If present, the contract's rendering providers will be patched to this exact
    /// value, overriding what was set before.
    /// </summary>
    [JsonPropertyName("regions")]
    public RegionsUpdate? Regions { get; set; }

    [JsonPropertyName("contract_status")]
    public ContractStatus? ContractStatus { get; set; }

    [JsonPropertyName("authorized_signatory")]
    public AuthorizedSignatoryUpdate? AuthorizedSignatory { get; set; }

    [JsonPropertyName("commercial_insurance_types")]
    public InsuranceTypes? CommercialInsuranceTypes { get; set; }

    [JsonPropertyName("medicare_insurance_types")]
    public InsuranceTypes? MedicareInsuranceTypes { get; set; }

    [JsonPropertyName("medicaid_insurance_types")]
    public InsuranceTypes? MedicaidInsuranceTypes { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
