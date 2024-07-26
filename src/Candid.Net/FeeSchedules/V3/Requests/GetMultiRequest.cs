using Candid.Net;
using Candid.Net.OrganizationProviders.V2;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record GetMultiRequest
{
    public string? PageToken { get; init; }

    /// <summary>
    /// Max number of dimensions returned. Defaults to 100. Max is 100.
    /// </summary>
    public int? Limit { get; init; }

    public DateOnly? ActiveDate { get; init; }

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
