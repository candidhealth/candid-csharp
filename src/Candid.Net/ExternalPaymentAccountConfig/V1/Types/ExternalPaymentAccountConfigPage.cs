using System.Text.Json.Serialization;
using Candid.Net.ExternalPaymentAccountConfig.V1;

#nullable enable

namespace Candid.Net.ExternalPaymentAccountConfig.V1;

public record ExternalPaymentAccountConfigPage
{
    [JsonPropertyName("items")]
    public IEnumerable<ExternalPaymentAccountConfig> Items { get; set; } =
        new List<ExternalPaymentAccountConfig>();
}
