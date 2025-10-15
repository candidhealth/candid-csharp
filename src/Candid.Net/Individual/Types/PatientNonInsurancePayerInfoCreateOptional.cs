using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Individual;

[Serializable]
public record PatientNonInsurancePayerInfoCreateOptional : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("non_insurance_payer_id")]
    public string? NonInsurancePayerId { get; set; }

    [JsonPropertyName("member_id")]
    public string? MemberId { get; set; }

    [JsonPropertyName("clinical_trial_info")]
    public IEnumerable<PatientClinicalTrialInfoCreate>? ClinicalTrialInfo { get; set; }

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
