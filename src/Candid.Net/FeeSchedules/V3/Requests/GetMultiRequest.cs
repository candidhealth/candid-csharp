using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;
using Candid.Net.OrganizationProviders.V2;

namespace Candid.Net.FeeSchedules.V3;

[Serializable]
public record GetMultiRequest
{
    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <summary>
    /// Max number of dimensions returned. Defaults to 100. Max is 100.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    [JsonIgnore]
    public DateOnly? ActiveDate { get; set; }

    [JsonIgnore]
    public string? PayerUuid { get; set; }

    [JsonIgnore]
    public string? OrganizationBillingProviderId { get; set; }

    [JsonIgnore]
    public IEnumerable<State> States { get; set; } = new List<State>();

    [JsonIgnore]
    public IEnumerable<string> ZipCodes { get; set; } = new List<string>();

    [JsonIgnore]
    public IEnumerable<LicenseType> LicenseTypes { get; set; } = new List<LicenseType>();

    [JsonIgnore]
    public IEnumerable<FacilityTypeCode> FacilityTypeCodes { get; set; } =
        new List<FacilityTypeCode>();

    [JsonIgnore]
    public IEnumerable<Candid.Net.Commons.NetworkType> NetworkTypes { get; set; } =
        new List<Candid.Net.Commons.NetworkType>();

    [JsonIgnore]
    public IEnumerable<string> PayerPlanGroupIds { get; set; } = new List<string>();

    [JsonIgnore]
    public string? CptCode { get; set; }

    [JsonIgnore]
    public IEnumerable<ProcedureModifier> Modifiers { get; set; } = new List<ProcedureModifier>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
