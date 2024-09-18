using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter.Lists.V1;

public record PatientListPage
{
    [JsonPropertyName("items")]
    public IEnumerable<PatientListItem> Items { get; set; } = new List<PatientListItem>();

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }
}
