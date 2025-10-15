using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.ExternalPaymentAccountConfig.V1;

[Serializable]
public record GetExternalPaymentAccountConfigsRequest
{
    /// <summary>
    /// Defaults to 100
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
