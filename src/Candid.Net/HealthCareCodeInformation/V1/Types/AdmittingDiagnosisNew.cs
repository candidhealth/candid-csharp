using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

/// <summary>
/// This corresponds to BJ or ABJ code qualifier values.
/// </summary>
[Serializable]
public record AdmittingDiagnosisNew : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("admitting_diagnosis_code_qualifier")]
    public required AdmittingDiagnosisCodeQualifier AdmittingDiagnosisCodeQualifier { get; set; }

    [JsonPropertyName("admitting_diagnosis_code")]
    public required string AdmittingDiagnosisCode { get; set; }

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
