namespace Candid.Net.InsuranceRefunds.V1;

public record GetMultiInsuranceRefundsRequest
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
    /// Defaults to refund_timestamp
    /// </summary>
    public InsuranceRefundSortField? Sort { get; set; }

    /// <summary>
    /// Sort direction. Defaults to descending order if not provided.
    /// </summary>
    public SortDirection? SortDirection { get; set; }

    public string? PageToken { get; set; }
}
