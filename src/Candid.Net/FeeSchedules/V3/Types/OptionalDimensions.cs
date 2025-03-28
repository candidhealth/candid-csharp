using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.OrganizationProviders.V2;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record OptionalDimensions
{
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
    public HashSet<NetworkType> NetworkTypes { get; set; } = new HashSet<NetworkType>();

    [JsonPropertyName("payer_plan_group_ids")]
    public HashSet<string> PayerPlanGroupIds { get; set; } = new HashSet<string>();

    [JsonPropertyName("cpt_code")]
    public string? CptCode { get; set; }

    [JsonPropertyName("modifiers")]
    public HashSet<ProcedureModifier> Modifiers { get; set; } = new HashSet<ProcedureModifier>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
