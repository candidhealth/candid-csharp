using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Credentialing.V2;

public record GetAllFacilityCredentialingSpansRequest
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
    /// Filter to a particular contracting provider.
    /// </summary>
    public string? ContractingProviderId { get; set; }

    /// <summary>
    /// Filter to a particular service facility.
    /// </summary>
    public string? ServiceFacilityId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
