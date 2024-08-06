using System.Text.Json.Serialization;
using Candid.Net.PatientRefunds.V1;

#nullable enable

namespace Candid.Net.PatientRefunds.V1;

public record PatientRefundsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<PatientRefund> Items { get; set; } = new List<PatientRefund>();
}
