using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.InsuranceRefunds.V1;

[Serializable]
public record GetMultiInsuranceRefundsRequest
{
    /// <summary>
    /// Defaults to 100. The value must be greater than 0 and less than 1000.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    [JsonIgnore]
    public string? PayerUuid { get; set; }

    [JsonIgnore]
    public string? ClaimId { get; set; }

    [JsonIgnore]
    public string? ServiceLineId { get; set; }

    [JsonIgnore]
    public string? BillingProviderId { get; set; }

    /// <summary>
    /// Defaults to refund_timestamp
    /// </summary>
    [JsonIgnore]
    public InsuranceRefundSortField? Sort { get; set; }

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
