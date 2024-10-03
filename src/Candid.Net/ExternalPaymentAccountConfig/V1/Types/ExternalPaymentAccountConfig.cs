using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ExternalPaymentAccountConfig.V1;

public record ExternalPaymentAccountConfig
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("account_name")]
    public required string AccountName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
