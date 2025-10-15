using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.ClinicalTrials.V1;

[Serializable]
public record MutableClinicalTrial : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Must be 8 characters long
    /// </summary>
    [JsonPropertyName("clinical_trial_number")]
    public required string ClinicalTrialNumber { get; set; }

    [JsonPropertyName("clinical_trial_phase")]
    public ClinicalTrialPhase? ClinicalTrialPhase { get; set; }

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
