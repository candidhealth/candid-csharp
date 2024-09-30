using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter;

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
}
