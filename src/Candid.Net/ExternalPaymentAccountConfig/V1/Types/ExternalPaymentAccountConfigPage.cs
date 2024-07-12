using System.Text.Json.Serialization;
using Candid.Net.ExternalPaymentAccountConfig.V1;

#nullable enable

namespace Candid.Net.ExternalPaymentAccountConfig.V1;

public record ExternalPaymentAccountConfigPage
{
    [JsonPropertyName("items")]
    public IEnumerable<ExternalPaymentAccountConfig> Items { get; init; } =
        new List<ExternalPaymentAccountConfig>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; init; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; init; }
}
