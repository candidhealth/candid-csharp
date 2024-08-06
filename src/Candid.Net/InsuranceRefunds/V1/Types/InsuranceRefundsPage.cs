using System.Text.Json.Serialization;
using Candid.Net.InsuranceRefunds.V1;

#nullable enable

namespace Candid.Net.InsuranceRefunds.V1;

public record InsuranceRefundsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<InsuranceRefund> Items { get; set; } = new List<InsuranceRefund>();
}
