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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
