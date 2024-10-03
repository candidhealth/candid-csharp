using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Remits.V1;

public record Payee
{
    [JsonPropertyName("payee_name")]
    public required string PayeeName { get; set; }

    [JsonPropertyName("payee_identifier")]
    public required object PayeeIdentifier { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
