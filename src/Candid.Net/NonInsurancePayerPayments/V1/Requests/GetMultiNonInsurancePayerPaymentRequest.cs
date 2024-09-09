namespace Candid.Net.NonInsurancePayerPayments.V1;

public record GetMultiNonInsurancePayerPaymentRequest
{
    /// <summary>
    /// Defaults to 100. The value must be greater than 0 and less than 1000.
    /// </summary>
    public int? Limit { get; set; }

    public string? NonInsurancePayerId { get; set; }

    public IEnumerable<string> CheckNumber { get; set; } = new List<string>();

    public string? InvoiceId { get; set; }

    /// <summary>
    /// Defaults to refund_timestamp
    /// </summary>
    public NonInsurancePayerPaymentSortField? Sort { get; set; }

    /// <summary>
    /// Sort direction. Defaults to descending order if not provided.
    /// </summary>
    public SortDirection? SortDirection { get; set; }

    public string? PageToken { get; set; }
}
