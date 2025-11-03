using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

/// <summary>
/// This corresponds to BN or ABN code qualifier values.
/// </summary>
[Serializable]
public record ExternalCauseOfInjuryNew : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("external_cause_of_injury_code_qualifier")]
    public required ExternalCauseOfInjuryCodeQualifier ExternalCauseOfInjuryCodeQualifier { get; set; }

    [JsonPropertyName("external_cause_of_injury_code")]
    public required string ExternalCauseOfInjuryCode { get; set; }

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
