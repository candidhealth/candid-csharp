using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.ImportInvoice.V1;

public record ImportInvoicesPage
{
    [JsonPropertyName("items")]
    public IEnumerable<ImportInvoice> Items { get; set; } = new List<ImportInvoice>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }
}
