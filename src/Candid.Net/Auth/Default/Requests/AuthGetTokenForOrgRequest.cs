using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Auth.Default;

public record AuthGetTokenForOrgRequest
{
    /// <summary>
    /// Organization ID to generate token for.
    /// </summary>
    [JsonPropertyName("org_id")]
    public required string OrgId { get; set; }

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

    /// <summary>
    /// Refreshes auth token for a given user &lt;&gt; org pair.
    /// </summary>
    [JsonPropertyName("force_token_refresh")]
    public bool? ForceTokenRefresh { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
