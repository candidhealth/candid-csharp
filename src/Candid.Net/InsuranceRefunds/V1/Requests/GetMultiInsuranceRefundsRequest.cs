using Candid.Net;
using Candid.Net.InsuranceRefunds.V1;

#nullable enable

namespace Candid.Net.InsuranceRefunds.V1;

public record GetMultiInsuranceRefundsRequest
{
    /// <summary>
    /// Defaults to 100. The value must be greater than 0 and less than 1000.
    /// </summary>
    public int? Limit { get; init; }

    public Guid? PayerUuid { get; init; }

    public Guid? ClaimId { get; init; }

    public Guid? ServiceLineId { get; init; }

    public Guid? BillingProviderId { get; init; }

    /// <summary>
    /// Defaults to refund_timestamp
    /// </summary>
    public InsuranceRefundSortField? Sort { get; init; }

    /// <summary>
    /// Sort direction. Defaults to descending order if not provided.
    /// </summary>
    public SortDirection? SortDirection { get; init; }

    public string? PageToken { get; init; }
}
