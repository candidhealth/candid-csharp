using Candid.Net;
using Candid.Net.FeeSchedules.V3;
using Candid.Net.OrganizationProviders.V2;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record GetUniqueDimensionValuesRequest
{
    public string? PageToken { get; init; }

    /// <summary>
    /// Max number of values returned. Defaults to 1000. Max is 1000.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The name of the dimension to fetch unique values for.
    /// </summary>
    public required DimensionName PivotDimension { get; init; }

    public string? PayerUuid { get; init; }

    public string? OrganizationBillingProviderId { get; init; }

    public State? States { get; init; }

    public string? ZipCodes { get; init; }

    public LicenseType? LicenseTypes { get; init; }

    public FacilityTypeCode? FacilityTypeCodes { get; init; }

    public NetworkType? NetworkTypes { get; init; }

    public string? CptCode { get; init; }

    public ProcedureModifier? Modifiers { get; init; }
}
