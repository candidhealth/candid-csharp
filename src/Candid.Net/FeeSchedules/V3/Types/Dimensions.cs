using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.OrganizationProviders.V2;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record Dimensions
{
    [JsonPropertyName("payer_uuid")]
    public required string PayerUuid { get; init; }

    [JsonPropertyName("organization_billing_provider_id")]
    public required string OrganizationBillingProviderId { get; init; }

    [JsonPropertyName("states")]
    public HashSet<State> States { get; init; } = new HashSet<State>();

    [JsonPropertyName("zip_codes")]
    public HashSet<string> ZipCodes { get; init; } = new HashSet<string>();

    [JsonPropertyName("license_types")]
    public HashSet<LicenseType> LicenseTypes { get; init; } = new HashSet<LicenseType>();

    [JsonPropertyName("facility_type_codes")]
    public HashSet<FacilityTypeCode> FacilityTypeCodes { get; init; } =
        new HashSet<FacilityTypeCode>();

    [JsonPropertyName("network_types")]
    public HashSet<NetworkType> NetworkTypes { get; init; } = new HashSet<NetworkType>();

    [JsonPropertyName("cpt_code")]
    public required string CptCode { get; init; }

    [JsonPropertyName("modifiers")]
    public HashSet<ProcedureModifier> Modifiers { get; init; } = new HashSet<ProcedureModifier>();
}
