using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Contracts.V2;

public record ContractsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<Contract> Items { get; set; } = new List<Contract>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }
}
