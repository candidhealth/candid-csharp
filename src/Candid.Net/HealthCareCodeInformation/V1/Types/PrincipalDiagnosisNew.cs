using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

/// <summary>
/// This corresponds to BK or ABK code qualifier values.
/// </summary>
[Serializable]
public record PrincipalDiagnosisNew : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("principal_diagnosis_code_qualifier")]
    public required PrincipalDiagnosisCodeQualifier PrincipalDiagnosisCodeQualifier { get; set; }

    [JsonPropertyName("primary_diagnosis_code")]
    public required string PrimaryDiagnosisCode { get; set; }

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
