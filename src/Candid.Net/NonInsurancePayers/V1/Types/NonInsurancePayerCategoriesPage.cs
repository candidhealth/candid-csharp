using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.NonInsurancePayers.V1;

public record NonInsurancePayerCategoriesPage
{
    [JsonPropertyName("items")]
    public IEnumerable<string> Items { get; set; } = new List<string>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
