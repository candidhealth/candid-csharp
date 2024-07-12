using System.Text.Json.Serialization;
using Candid.Net.PatientPayments.V4;

#nullable enable

namespace Candid.Net.PatientPayments.V4;

public record PatientPaymentsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<PatientPayment> Items { get; init; } = new List<PatientPayment>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; init; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; init; }
}
