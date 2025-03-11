using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ClinicalTrials.V1;

public record MutableClinicalTrial
{
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
