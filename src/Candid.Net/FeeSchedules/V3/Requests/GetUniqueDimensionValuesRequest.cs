using Candid.Net;
using Candid.Net.OrganizationProviders.V2;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record GetUniqueDimensionValuesRequest
{
    public string? PageToken { get; set; }

    /// <summary>
    /// Max number of values returned. Defaults to 1000. Max is 1000.
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// The name of the dimension to fetch unique values for.
    /// </summary>
    public required DimensionName PivotDimension { get; set; }

    public string? PayerUuid { get; set; }

    public string? OrganizationBillingProviderId { get; set; }

    public IEnumerable<State> States { get; set; } = new List<State>();

    public IEnumerable<string> ZipCodes { get; set; } = new List<string>();

    public IEnumerable<LicenseType> LicenseTypes { get; set; } = new List<LicenseType>();

    public IEnumerable<FacilityTypeCode> FacilityTypeCodes { get; set; } =
        new List<FacilityTypeCode>();

    public IEnumerable<NetworkType> NetworkTypes { get; set; } = new List<NetworkType>();

    public string? CptCode { get; set; }

    public IEnumerable<ProcedureModifier> Modifiers { get; set; } = new List<ProcedureModifier>();
}
