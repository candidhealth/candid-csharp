using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCapture.V1;

public record ChargeCapturePostBilledChange
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("message")]
    public required string Message { get; set; }

    [JsonPropertyName("resolved")]
    public required bool Resolved { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
