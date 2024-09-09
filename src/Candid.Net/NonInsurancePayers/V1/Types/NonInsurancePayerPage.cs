using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.NonInsurancePayers.V1;

public record NonInsurancePayerPage
{
    [JsonPropertyName("items")]
    public IEnumerable<NonInsurancePayer> Items { get; set; } = new List<NonInsurancePayer>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }
}
