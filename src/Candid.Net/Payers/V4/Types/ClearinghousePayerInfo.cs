using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Payers.V4;

public record ClearinghousePayerInfo
{
    /// <summary>
    /// The clearinghouse display name of the payer.
    /// </summary>
    [JsonPropertyName("payer_name")]
    public required string PayerName { get; set; }

    /// <summary>
    /// Payer IDs for professional claims
    /// </summary>
    [JsonPropertyName("professional_payer_ids")]
    public required PayerIds ProfessionalPayerIds { get; set; }

    /// <summary>
    /// Payer IDs for institutional claims
    /// </summary>
    [JsonPropertyName("institutional_payer_ids")]
    public required PayerIds InstitutionalPayerIds { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
