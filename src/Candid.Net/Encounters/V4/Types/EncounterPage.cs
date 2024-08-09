using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record EncounterPage
{
    [JsonPropertyName("items")]
    public IEnumerable<Encounter> Items { get; set; } = new List<Encounter>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }
}
