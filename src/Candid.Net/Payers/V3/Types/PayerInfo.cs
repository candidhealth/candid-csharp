using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Payers.V3;

public record PayerInfo
{
    [JsonPropertyName("payer_id")]
    public required string PayerId { get; set; }

    [JsonPropertyName("payer_name")]
    public required string PayerName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
