using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public record AllocationCreate
{
    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonPropertyName("target")]
    public required object Target { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
