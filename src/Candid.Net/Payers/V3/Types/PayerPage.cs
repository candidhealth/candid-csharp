using System.Text.Json.Serialization;
using Candid.Net.Payers.V3;

#nullable enable

namespace Candid.Net.Payers.V3;

public record PayerPage
{
    [JsonPropertyName("items")]
    public IEnumerable<Payer> Items { get; init; } = new List<Payer>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; init; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; init; }
}
