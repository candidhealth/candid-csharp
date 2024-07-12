using System.Text.Json.Serialization;
using Candid.Net.FeeSchedules.V3;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record DimensionMatch
{
    [JsonPropertyName("payer")]
    public required MatchPayer Payer { get; init; }

    [JsonPropertyName("geography")]
    public required MatchGeo Geography { get; init; }

    [JsonPropertyName("organization_billing_provider")]
    public required MatchProvider OrganizationBillingProvider { get; init; }

    [JsonPropertyName("date_of_service")]
    public required MatchDate DateOfService { get; init; }

    [JsonPropertyName("cpt_code")]
    public required MatchCptCode CptCode { get; init; }

    [JsonPropertyName("modifiers")]
    public required MatchModifiers Modifiers { get; init; }

    [JsonPropertyName("license_type")]
    public required MatchLicenseType LicenseType { get; init; }

    [JsonPropertyName("facility_type_code")]
    public required MatchFacilityTypeCode FacilityTypeCode { get; init; }

    [JsonPropertyName("network_types")]
    public required MatchNetworkTypes NetworkTypes { get; init; }
}
