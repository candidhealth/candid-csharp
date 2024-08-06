using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Auth.V2;

public record AuthGetTokenResponse
{
    [JsonPropertyName("access_token")]
    public required string AccessToken { get; set; }

    /// <summary>
    /// Time in seconds.
    /// </summary>
    [JsonPropertyName("expires_in")]
    public required int ExpiresIn { get; set; }

    [JsonPropertyName("token_type")]
    public required string TokenType { get; set; }
}
