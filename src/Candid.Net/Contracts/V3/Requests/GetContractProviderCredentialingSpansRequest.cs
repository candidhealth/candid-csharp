using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Contracts.V3;

[Serializable]
public record GetContractProviderCredentialingSpansRequest
{
    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <summary>
    /// Max number of providers returned per page. Defaults to 100. Max is 1000.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
