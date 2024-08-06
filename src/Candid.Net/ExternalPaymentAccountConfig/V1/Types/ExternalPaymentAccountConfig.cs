using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.ExternalPaymentAccountConfig.V1;

public record ExternalPaymentAccountConfig
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("account_name")]
    public required string AccountName { get; set; }
}
