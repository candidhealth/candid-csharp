using Candid.Net.Core;

#nullable enable

namespace Candid.Net.InsurancePayments.V1;

public record GetMultiInsurancePaymentRequest
{
    /// <summary>
    /// Defaults to 100. The value must be greater than 0 and less than 1000.
    /// </summary>
    public int? Limit { get; set; }

    public string? PayerUuid { get; set; }

    public string? ClaimId { get; set; }

    public string? ServiceLineId { get; set; }

    public string? BillingProviderId { get; set; }

    /// <summary>
    /// Defaults to payment_timestamp
    /// </summary>
    public InsurancePaymentSortField? Sort { get; set; }

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
