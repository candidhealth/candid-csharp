using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.ExternalPaymentAccountConfig.V1;

public record ExternalPaymentAccountConfig
{
    [JsonPropertyName("id")]
    public required Guid Id { get; init; }

    [JsonPropertyName("account_name")]
    public required string AccountName { get; init; }
}
