using System.Text.Json.Serialization;
using Candid.Net.InsurancePayments.V1;

#nullable enable

namespace Candid.Net.InsurancePayments.V1;

public record InsurancePaymentsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<InsurancePayment> Items { get; set; } = new List<InsurancePayment>();
}
