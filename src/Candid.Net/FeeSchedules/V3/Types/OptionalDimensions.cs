using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;
using Candid.Net.OrganizationProviders.V2;

namespace Candid.Net.FeeSchedules.V3;

/// <summary>
/// A dimensions object where all properties are optional.
/// </summary>
[Serializable]
public record OptionalDimensions : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("payer_uuid")]
    public string? PayerUuid { get; set; }

    [JsonPropertyName("organization_billing_provider_id")]
    public string? OrganizationBillingProviderId { get; set; }

    [JsonPropertyName("states")]
    public HashSet<State> States { get; set; } = new HashSet<State>();

    [JsonPropertyName("zip_codes")]
    public HashSet<string> ZipCodes { get; set; } = new HashSet<string>();

    [JsonPropertyName("license_types")]
    public HashSet<LicenseType> LicenseTypes { get; set; } = new HashSet<LicenseType>();

    [JsonPropertyName("facility_type_codes")]
    public HashSet<FacilityTypeCode> FacilityTypeCodes { get; set; } =
        new HashSet<FacilityTypeCode>();

    [JsonPropertyName("network_types")]
    public HashSet<Candid.Net.Commons.NetworkType> NetworkTypes { get; set; } =
        new HashSet<Candid.Net.Commons.NetworkType>();

    [JsonPropertyName("payer_plan_group_ids")]
    public HashSet<string> PayerPlanGroupIds { get; set; } = new HashSet<string>();

    [JsonPropertyName("cpt_code")]
    public string? CptCode { get; set; }

    [JsonPropertyName("modifiers")]
    public HashSet<ProcedureModifier> Modifiers { get; set; } = new HashSet<ProcedureModifier>();

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
