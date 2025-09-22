using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Common;

public record ErrorBase4Xx
{
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    [JsonPropertyName("data")]
    public object? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
