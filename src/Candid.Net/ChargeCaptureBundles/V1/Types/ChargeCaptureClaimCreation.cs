using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.ChargeCapture.V1;
using Candid.Net.Core;

namespace Candid.Net.ChargeCaptureBundles.V1;

[Serializable]
public record ChargeCaptureClaimCreation : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("created_encounter_id")]
    public string? CreatedEncounterId { get; set; }

    /// <summary>
    /// Status of the Claim Creation, Successful means that the Claim Creation created a corresponding Claim
    /// </summary>
    [JsonPropertyName("status")]
    public required ChargeCaptureClaimCreationStatus Status { get; set; }

    /// <summary>
    /// A dictionary of characteristics that are used to group charge captures together based on the bundling configuration.
    /// Example: {"service_facility.npi": "99999999", "date_of_service": "2023-01-01"}
    /// </summary>
    [JsonPropertyName("characteristics")]
    public Dictionary<string, object?> Characteristics { get; set; } =
        new Dictionary<string, object?>();

    /// <summary>
    /// All errors that were found when the Claim was attempted to be created.
    /// Errors can correspond to the Claim Creation as a whole or specific underlying Charge Captures.
    /// </summary>
    [JsonPropertyName("errors")]
    public IEnumerable<ChargeCaptureError> Errors { get; set; } = new List<ChargeCaptureError>();

    /// <summary>
    /// If a ChargeCaptureBundle attempts creation, this is the input that was created from the underlying charges and used to attempt encounter creation.
    /// </summary>
    [JsonPropertyName("encounter_creation_input")]
    public ChargeCaptureData? EncounterCreationInput { get; set; }

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
