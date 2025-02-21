using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Appointments.V1;

public record VisitsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<Visit> Items { get; set; } = new List<Visit>();

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
