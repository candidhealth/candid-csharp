using Candid.Net;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PatientPayments.V4;

public record GetMultiPatientPaymentsRequest
{
    /// <summary>
    /// Defaults to 100. The value must be greater than 0 and less than 1000.
    /// </summary>
    public int? Limit { get; set; }

    public string? PatientExternalId { get; set; }

    public string? ClaimId { get; set; }

    public string? ServiceLineId { get; set; }

    public string? BillingProviderId { get; set; }

    /// <summary>
    /// returns payments with unattributed allocations if set to true
    /// </summary>
    public bool? Unattributed { get; set; }

    public string? InvoiceId { get; set; }

    public IEnumerable<PatientTransactionSource> Sources { get; set; } =
        new List<PatientTransactionSource>();

    /// <summary>
    /// Defaults to payment_timestamp
    /// </summary>
    public PatientPaymentSortField? Sort { get; set; }

    /// <summary>
    /// Sort direction. Defaults to descending order if not provided.
    /// </summary>
    public SortDirection? SortDirection { get; set; }

    public string? PageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
