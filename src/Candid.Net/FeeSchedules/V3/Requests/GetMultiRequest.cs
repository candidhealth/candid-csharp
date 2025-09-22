using Candid.Net.Commons;
using Candid.Net.Core;
using Candid.Net.OrganizationProviders.V2;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record GetMultiRequest
{
    public string? PageToken { get; set; }

    /// <summary>
    /// Max number of dimensions returned. Defaults to 100. Max is 100.
    /// </summary>
    public int? Limit { get; set; }

    public DateOnly? ActiveDate { get; set; }

    public string? PayerUuid { get; set; }

    public string? OrganizationBillingProviderId { get; set; }

    public IEnumerable<State> States { get; set; } = new List<State>();

    public IEnumerable<string> ZipCodes { get; set; } = new List<string>();

    public IEnumerable<LicenseType> LicenseTypes { get; set; } = new List<LicenseType>();

    public IEnumerable<FacilityTypeCode> FacilityTypeCodes { get; set; } =
        new List<FacilityTypeCode>();

    public IEnumerable<Commons.NetworkType> NetworkTypes { get; set; } =
        new List<Commons.NetworkType>();

    public IEnumerable<string> PayerPlanGroupIds { get; set; } = new List<string>();

    public string? CptCode { get; set; }

    public IEnumerable<ProcedureModifier> Modifiers { get; set; } = new List<ProcedureModifier>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
