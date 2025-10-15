using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.ClinicalTrials.V1;
using Candid.Net.Core;

namespace Candid.Net.Individual;

[Serializable]
public record PatientClinicalTrialInfo : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("clinical_trial_arm")]
    public string? ClinicalTrialArm { get; set; }

    [JsonPropertyName("clinical_trial")]
    public required ClinicalTrial ClinicalTrial { get; set; }

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
