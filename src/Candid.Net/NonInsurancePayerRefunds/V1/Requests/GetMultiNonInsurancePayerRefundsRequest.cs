using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.NonInsurancePayerRefunds.V1;

[Serializable]
public record GetMultiNonInsurancePayerRefundsRequest
{
    /// <summary>
    /// Defaults to 100. The value must be greater than 0 and less than 1000.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    [JsonIgnore]
    public string? NonInsurancePayerId { get; set; }

    [JsonIgnore]
    public IEnumerable<string> CheckNumber { get; set; } = new List<string>();

    [JsonIgnore]
    public string? InvoiceId { get; set; }

    /// <summary>
    /// Defaults to refund_timestamp
    /// </summary>
    [JsonIgnore]
    public NonInsurancePayerRefundSortField? Sort { get; set; }

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
