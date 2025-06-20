using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public record PatientNonInsurancePayerInfoCreateOptional
{
    [JsonPropertyName("non_insurance_payer_id")]
    public string? NonInsurancePayerId { get; set; }

    [JsonPropertyName("member_id")]
    public string? MemberId { get; set; }

    [JsonPropertyName("clinical_trial_info")]
    public IEnumerable<PatientClinicalTrialInfoCreate>? ClinicalTrialInfo { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
