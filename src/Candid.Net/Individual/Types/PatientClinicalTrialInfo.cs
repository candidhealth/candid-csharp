using System.Text.Json.Serialization;
using Candid.Net.ClinicalTrials.V1;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public record PatientClinicalTrialInfo
{
    [JsonPropertyName("clinical_trial_arm")]
    public string? ClinicalTrialArm { get; set; }

    [JsonPropertyName("clinical_trial")]
    public required ClinicalTrial ClinicalTrial { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
