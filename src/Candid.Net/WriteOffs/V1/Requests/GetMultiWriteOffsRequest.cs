using Candid.Net;
using Candid.Net.WriteOffs.V1;

#nullable enable

namespace Candid.Net.WriteOffs.V1;

public record GetMultiWriteOffsRequest
{
    /// <summary>
    /// Defaults to 100. The value must be greater than 0 and less than 1000.
    /// </summary>
    public int? Limit { get; init; }

    public string? PatientExternalId { get; init; }

    public Guid? PayerUuid { get; init; }

    public Guid? ServiceLineId { get; init; }

    public Guid? ClaimId { get; init; }

    public Guid? BillingProviderId { get; init; }

    /// <summary>
    /// Defaults to write_off_timestamp
    /// </summary>
    public WriteOffSortField? Sort { get; init; }

    /// <summary>
    /// Sort direction. Defaults to descending order if not provided.
    /// </summary>
    public SortDirection? SortDirection { get; init; }

    public string? PageToken { get; init; }

    /// <summary>
    /// Filters the returned values to include only the provided account types.
    /// </summary>
    public AccountType? AccountTypes { get; init; }
}
