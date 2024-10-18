using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Credentialing.V2;

public record GetAllProviderCredentialingSpansRequest
{
    /// <summary>
    /// Maximum number of entities per page, defaults to 100.
    /// </summary>
    public int? Limit { get; set; }

    public string? PageToken { get; set; }

    /// <summary>
    /// Filter by payer.
    /// </summary>
    public string? PayerUuid { get; set; }

    /// <summary>
    /// Filter to credentialing spans where the provider is a rendering provider.
    /// </summary>
    public bool? AsRenderingProvider { get; set; }

    /// <summary>
    /// Filter to credentialing spans where the provider is a contracting provider.
    /// </summary>
    public bool? AsContractingProvider { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
