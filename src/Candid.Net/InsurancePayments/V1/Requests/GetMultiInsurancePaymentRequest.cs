using Candid.Net;
using Candid.Net.InsurancePayments.V1;

#nullable enable

namespace Candid.Net.InsurancePayments.V1;

public record GetMultiInsurancePaymentRequest
{
    /// <summary>
    /// Defaults to 100. The value must be greater than 0 and less than 1000.
    /// </summary>
    public int? Limit { get; init; }

    public string? PayerUuid { get; init; }

    public string? ClaimId { get; init; }

    public string? ServiceLineId { get; init; }

    public string? BillingProviderId { get; init; }

    /// <summary>
    /// Defaults to payment_timestamp
    /// </summary>
    public InsurancePaymentSortField? Sort { get; init; }

    /// <summary>
    /// Sort direction. Defaults to descending order if not provided.
    /// </summary>
    public SortDirection? SortDirection { get; init; }

    public string? PageToken { get; init; }
}
