using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public record PatientClinicalTrialInfoCreate
{
    [JsonPropertyName("clinical_trial_arm")]
    public string? ClinicalTrialArm { get; set; }

    [JsonPropertyName("clinical_trial_id")]
    public required string ClinicalTrialId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
