using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Patients.V1;

/// <summary>
/// Granular consent for electronic communication channels.
/// </summary>
[Serializable]
public record ElectronicCommunicationConsent : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Consent for text/SMS communication.
    /// </summary>
    [JsonPropertyName("text_communication_consent")]
    public bool? TextCommunicationConsent { get; set; }

    /// <summary>
    /// Consent for email communication.
    /// </summary>
    [JsonPropertyName("email_communication_consent")]
    public bool? EmailCommunicationConsent { get; set; }

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
