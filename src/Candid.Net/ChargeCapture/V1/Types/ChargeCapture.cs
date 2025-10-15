using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.ChargeCapture.V1;

[Serializable]
public record ChargeCapture : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("status")]
    public required ChargeCaptureStatus Status { get; set; }

    [JsonPropertyName("charge_capture_data")]
    public required ChargeCaptureData ChargeCaptureData { get; set; }

    [JsonPropertyName("date_of_service")]
    public DateOnly? DateOfService { get; set; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; set; }

    [JsonPropertyName("charge_external_id")]
    public required string ChargeExternalId { get; set; }

    [JsonPropertyName("ehr_source_url")]
    public string? EhrSourceUrl { get; set; }

    [JsonPropertyName("originating_system")]
    public string? OriginatingSystem { get; set; }

    [JsonPropertyName("claim_creation_category")]
    public string? ClaimCreationCategory { get; set; }

    [JsonPropertyName("error")]
    public ChargeCaptureError? Error { get; set; }

    [JsonPropertyName("updates")]
    public IEnumerable<ChargeCapturePostBilledChange> Updates { get; set; } =
        new List<ChargeCapturePostBilledChange>();

    [JsonPropertyName("claim_creation_id")]
    public string? ClaimCreationId { get; set; }

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
