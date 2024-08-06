using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Auth.V2;

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
}
