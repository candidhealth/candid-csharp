using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.NonInsurancePayers.V1;

#nullable enable

namespace Candid.Net;

public record PatientNonInsurancePayerInfo
{
    [JsonPropertyName("non_insurance_payer")]
    public required NonInsurancePayer NonInsurancePayer { get; set; }

    [JsonPropertyName("member_id")]
    public string? MemberId { get; set; }

    /// <summary>
    /// A patient cannot be associated with a given trial more than once
    /// </summary>
    [JsonPropertyName("clinical_trial_info")]
    public IEnumerable<PatientClinicalTrialInfo> ClinicalTrialInfo { get; set; } =
        new List<PatientClinicalTrialInfo>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
