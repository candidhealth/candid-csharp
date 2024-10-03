using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ExternalPaymentAccountConfig.V1;

public record ExternalPaymentAccountConfigPage
{
    [JsonPropertyName("items")]
    public IEnumerable<ExternalPaymentAccountConfig> Items { get; set; } =
        new List<ExternalPaymentAccountConfig>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
