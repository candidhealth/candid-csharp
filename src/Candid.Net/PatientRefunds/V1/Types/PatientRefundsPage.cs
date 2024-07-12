using System.Text.Json.Serialization;
using Candid.Net.PatientRefunds.V1;

#nullable enable

namespace Candid.Net.PatientRefunds.V1;

public record PatientRefundsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<PatientRefund> Items { get; init; } = new List<PatientRefund>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; init; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; init; }
}
