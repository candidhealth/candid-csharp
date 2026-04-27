using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.OrganizationExternalProviders.V1;

[Serializable]
public record OrganizationExternalProviderScanRequest
{
    [JsonIgnore]
    public required DateTime Since { get; set; }

    [JsonIgnore]
    public int? MaxResults { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
