using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Lists.V1;

public record AppointmentListPage
{
    [JsonPropertyName("items")]
    public IEnumerable<AppointmentListItem> Items { get; set; } = new List<AppointmentListItem>();

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
