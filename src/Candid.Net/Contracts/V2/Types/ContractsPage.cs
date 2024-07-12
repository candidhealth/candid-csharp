using System.Text.Json.Serialization;
using Candid.Net.Contracts.V2;

#nullable enable

namespace Candid.Net.Contracts.V2;

public record ContractsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<Contract> Items { get; init; } = new List<Contract>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; init; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; init; }
}
