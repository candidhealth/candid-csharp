using global::Candid.Net;
using global::Candid.Net.Commons;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.FeeSchedules.V3;

/// <summary>
/// The dimension values to match a rate against, equivalent to a service line. An omitted optional dimension only matches rates that have no restriction on that dimension.
/// </summary>
[Serializable]
public record BatchMatchPoint : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("payer_uuid")]
    public required string PayerUuid { get; set; }

    [JsonPropertyName("organization_billing_provider_id")]
    public required string OrganizationBillingProviderId { get; set; }

    /// <summary>
    /// Matched case-insensitively.
    /// </summary>
    [JsonPropertyName("cpt_code")]
    public required string CptCode { get; set; }

    /// <summary>
    /// The rate entry in effect on this date is used.
    /// </summary>
    [JsonPropertyName("date_of_service")]
    public required DateOnly DateOfService { get; set; }

    /// <summary>
    /// Defaults to no modifiers.
    /// </summary>
    [JsonPropertyName("modifiers")]
    public IEnumerable<ProcedureModifier>? Modifiers { get; set; }

    [JsonPropertyName("facility_type_code")]
    public FacilityTypeCode? FacilityTypeCode { get; set; }

    [JsonPropertyName("state")]
    public State? State { get; set; }

    /// <summary>
    /// Only the first 5 digits are used, so ZIP+4 values are accepted.
    /// </summary>
    [JsonPropertyName("zip_code")]
    public string? ZipCode { get; set; }

    /// <summary>
    /// The rendering provider's license type.
    /// </summary>
    [JsonPropertyName("license_type")]
    public global::Candid.Net.OrganizationProviders.V2.LicenseType? LicenseType { get; set; }

    [JsonPropertyName("network_types")]
    public IEnumerable<global::Candid.Net.Commons.NetworkType>? NetworkTypes { get; set; }

    [JsonPropertyName("payer_plan_group_id")]
    public string? PayerPlanGroupId { get; set; }

    /// <summary>
    /// The number of units. Defaults to 1.
    /// </summary>
    [JsonPropertyName("quantity")]
    public string? Quantity { get; set; }

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
