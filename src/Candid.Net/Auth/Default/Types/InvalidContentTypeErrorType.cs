using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Auth.Default;

public record InvalidContentTypeErrorType
{
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
