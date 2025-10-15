using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.NonInsurancePayers.V1;

namespace Candid.Net.Individual;

[Serializable]
public record PatientNonInsurancePayerInfo : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
