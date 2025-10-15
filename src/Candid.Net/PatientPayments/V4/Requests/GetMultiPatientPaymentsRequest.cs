using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.Financials;

namespace Candid.Net.PatientPayments.V4;

[Serializable]
public record GetMultiPatientPaymentsRequest
{
    /// <summary>
    /// Defaults to 100. The value must be greater than 0 and less than 1000.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    [JsonIgnore]
    public string? PatientExternalId { get; set; }

    [JsonIgnore]
    public string? ClaimId { get; set; }

    [JsonIgnore]
    public string? ServiceLineId { get; set; }

    [JsonIgnore]
    public string? BillingProviderId { get; set; }

    /// <summary>
    /// returns payments with unattributed allocations if set to true
    /// </summary>
    [JsonIgnore]
    public bool? Unattributed { get; set; }

    [JsonIgnore]
    public string? InvoiceId { get; set; }

    [JsonIgnore]
    public IEnumerable<PatientTransactionSource> Sources { get; set; } =
        new List<PatientTransactionSource>();

    /// <summary>
    /// Defaults to payment_timestamp
    /// </summary>
    [JsonIgnore]
    public PatientPaymentSortField? Sort { get; set; }

    /// <summary>
    /// Sort direction. Defaults to descending order if not provided.
    /// </summary>
    [JsonIgnore]
    public global::Candid.Net.Commons.SortDirection? SortDirection { get; set; }

    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
