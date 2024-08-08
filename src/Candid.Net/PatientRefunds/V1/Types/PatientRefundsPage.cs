using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PatientRefunds.V1;

public record PatientRefundsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<PatientRefund> Items { get; set; } = new List<PatientRefund>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }
}
