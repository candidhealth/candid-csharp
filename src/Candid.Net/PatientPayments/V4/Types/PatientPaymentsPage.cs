using System.Text.Json.Serialization;
using Candid.Net.PatientPayments.V4;

#nullable enable

namespace Candid.Net.PatientPayments.V4;

public record PatientPaymentsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<PatientPayment> Items { get; set; } = new List<PatientPayment>();
}
