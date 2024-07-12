using Candid.Net;
using Candid.Net.PatientRefunds.V1;

#nullable enable

namespace Candid.Net.PatientRefunds.V1;

public record GetMultiPatientRefundsRequest
{
    /// <summary>
    /// Defaults to 100. The value must be greater than 0 and less than 1000.
    /// </summary>
    public int? Limit { get; init; }

    public string? PatientExternalId { get; init; }

    public Guid? ClaimId { get; init; }

    public Guid? ServiceLineId { get; init; }

    public Guid? BillingProviderId { get; init; }

    /// <summary>
    /// returns payments with unattributed allocations if set to true
    /// </summary>
    public bool? Unattributed { get; init; }

    public Guid? InvoiceId { get; init; }

    public PatientTransactionSource? Sources { get; init; }

    /// <summary>
    /// Defaults to refund_timestamp
    /// </summary>
    public PatientRefundSortField? Sort { get; init; }

    /// <summary>
    /// Sort direction. Defaults to descending order if not provided.
    /// </summary>
    public SortDirection? SortDirection { get; init; }

    public string? PageToken { get; init; }
}
