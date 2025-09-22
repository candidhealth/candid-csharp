using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Common;

public record AdditionalPayerInformation
{
    [JsonPropertyName("availity_eligibility_id")]
    public string? AvailityEligibilityId { get; set; }

    [JsonPropertyName("availity_payer_id")]
    public string? AvailityPayerId { get; set; }

    [JsonPropertyName("availity_payer_name")]
    public string? AvailityPayerName { get; set; }

    [JsonPropertyName("availity_remittance_payer_id")]
    public string? AvailityRemittancePayerId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
