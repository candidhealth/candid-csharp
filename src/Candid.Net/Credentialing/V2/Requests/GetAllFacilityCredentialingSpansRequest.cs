using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Credentialing.V2;

[Serializable]
public record GetAllFacilityCredentialingSpansRequest
{
    /// <summary>
    /// Maximum number of entities per page, defaults to 100.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <summary>
    /// Filter by payer.
    /// </summary>
    [JsonIgnore]
    public string? PayerUuid { get; set; }

    /// <summary>
    /// Filter to a particular contracting provider.
    /// </summary>
    [JsonIgnore]
    public string? ContractingProviderId { get; set; }

    /// <summary>
    /// Filter to a particular service facility.
    /// </summary>
    [JsonIgnore]
    public string? ServiceFacilityId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
