using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.FeeSchedules.V3;

/// <summary>
/// Dimension matching for a service line
/// </summary>
[Serializable]
public record DimensionMatch : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonPropertyName("payer_plan_groups")]
    public required MatchPayerPlanGroups PayerPlanGroups { get; set; }

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
