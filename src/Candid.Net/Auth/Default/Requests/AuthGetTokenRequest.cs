using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Auth.Default;

[Serializable]
public record AuthGetTokenRequest
{
    /// <summary>
    /// Your application's Client ID.
    /// </summary>
    [JsonPropertyName("client_id")]
    public required string ClientId { get; set; }

    /// <summary>
    /// Your application's Client Secret.
    /// </summary>
    [JsonPropertyName("client_secret")]
    public required string ClientSecret { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
