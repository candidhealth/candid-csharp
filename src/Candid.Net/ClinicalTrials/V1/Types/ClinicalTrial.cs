using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ClinicalTrials.V1;

public record ClinicalTrial
{
    [JsonPropertyName("clinical_trial_id")]
    public required string ClinicalTrialId { get; set; }

    [JsonPropertyName("non_insurance_payer_id")]
    public required string NonInsurancePayerId { get; set; }

    [JsonPropertyName("is_active")]
    public required bool IsActive { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Must be 8 characters long
    /// </summary>
    [JsonPropertyName("clinical_trial_number")]
    public required string ClinicalTrialNumber { get; set; }

    [JsonPropertyName("clinical_trial_phase")]
    public ClinicalTrialPhase? ClinicalTrialPhase { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
