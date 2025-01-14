using System.Text.Json.Serialization;
using Candid.Net.Core;

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

    [JsonPropertyName("total")]
    public required int Total { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
