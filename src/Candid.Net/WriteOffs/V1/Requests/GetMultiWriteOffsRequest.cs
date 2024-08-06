using Candid.Net;
using Candid.Net.WriteOffs.V1;

#nullable enable

namespace Candid.Net.WriteOffs.V1;

public record GetMultiWriteOffsRequest
{
    /// <summary>
    /// Defaults to 100. The value must be greater than 0 and less than 1000.
    /// </summary>
    public int? Limit { get; set; }

    public string? PatientExternalId { get; set; }

    public string? PayerUuid { get; set; }

    public string? ServiceLineId { get; set; }

    public string? ClaimId { get; set; }

    public string? BillingProviderId { get; set; }

    /// <summary>
    /// Defaults to write_off_timestamp
    /// </summary>
    public WriteOffSortField? Sort { get; set; }

    /// <summary>
    /// Sort direction. Defaults to descending order if not provided.
    /// </summary>
    public SortDirection? SortDirection { get; set; }

    public string? PageToken { get; set; }

    /// <summary>
    /// Filters the returned values to include only the provided account types.
    /// </summary>
    public IEnumerable<AccountType> AccountTypes { get; set; } = new List<AccountType>();
}
