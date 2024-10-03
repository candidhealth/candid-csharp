using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ExternalPaymentAccountConfig.V1;

public record GetExternalPaymentAccountConfigsRequest
{
    /// <summary>
    /// Defaults to 100
    /// </summary>
    public int? Limit { get; set; }

    public string? PageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
