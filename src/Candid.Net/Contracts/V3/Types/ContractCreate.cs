using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Contracts.V2;
using Candid.Net.Core;

namespace Candid.Net.Contracts.V3;

[Serializable]
public record ContractCreate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The type of contract
    /// </summary>
    [JsonPropertyName("contract_type")]
    public required ContractType ContractType { get; set; }

    /// <summary>
    /// The UUID of the provider under agreement to the contract
    /// </summary>
    [JsonPropertyName("contracting_provider_id")]
    public required string ContractingProviderId { get; set; }

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
    public required Regions Regions { get; set; }

    [JsonPropertyName("contract_status")]
    public ContractStatus? ContractStatus { get; set; }

    [JsonPropertyName("authorized_signatory")]
    public AuthorizedSignatory? AuthorizedSignatory { get; set; }

    /// <summary>
    /// The commercial plan insurance types this contract applies.
    /// </summary>
    [JsonPropertyName("commercial_insurance_types")]
    public required InsuranceTypes CommercialInsuranceTypes { get; set; }

    /// <summary>
    /// The Medicare plan insurance types this contract applies.
    /// </summary>
    [JsonPropertyName("medicare_insurance_types")]
    public required InsuranceTypes MedicareInsuranceTypes { get; set; }

    /// <summary>
    /// The Medicaid plan insurance types this contract applies.
    /// </summary>
    [JsonPropertyName("medicaid_insurance_types")]
    public required InsuranceTypes MedicaidInsuranceTypes { get; set; }

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
