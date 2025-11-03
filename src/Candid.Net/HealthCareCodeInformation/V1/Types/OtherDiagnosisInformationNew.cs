using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

/// <summary>
/// This corresponds to BF and ABF code qualifier values.
/// </summary>
[Serializable]
public record OtherDiagnosisInformationNew : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("other_diagnosis_code_qualifier")]
    public required OtherDiagnosisInformationCodeQualifier OtherDiagnosisCodeQualifier { get; set; }

    [JsonPropertyName("other_diagnosis")]
    public required string OtherDiagnosis { get; set; }

    [JsonPropertyName("present_on_admission_indicator")]
    public PresentOnAdmissionIndicatorCode? PresentOnAdmissionIndicator { get; set; }

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
