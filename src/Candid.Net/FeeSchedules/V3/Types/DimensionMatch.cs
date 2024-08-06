using System.Text.Json.Serialization;
using Candid.Net.FeeSchedules.V3;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record DimensionMatch
{
    [JsonPropertyName("payer")]
    public required MatchPayer Payer { get; set; }

    [JsonPropertyName("geography")]
    public required MatchGeo Geography { get; set; }

    [JsonPropertyName("organization_billing_provider")]
    public required MatchProvider OrganizationBillingProvider { get; set; }

    [JsonPropertyName("date_of_service")]
    public required MatchDate DateOfService { get; set; }

    [JsonPropertyName("cpt_code")]
    public required MatchCptCode CptCode { get; set; }

    [JsonPropertyName("modifiers")]
    public required MatchModifiers Modifiers { get; set; }

    [JsonPropertyName("license_type")]
    public required MatchLicenseType LicenseType { get; set; }

    [JsonPropertyName("facility_type_code")]
    public required MatchFacilityTypeCode FacilityTypeCode { get; set; }

    [JsonPropertyName("network_types")]
    public required MatchNetworkTypes NetworkTypes { get; set; }
}
