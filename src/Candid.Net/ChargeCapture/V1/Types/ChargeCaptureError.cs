using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.ChargeCapture.V1;

[Serializable]
public record ChargeCaptureError : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The underlying Charge Capture that this error object references.
    /// The Charge Capture referenced will be a part of the Claim Creation tied to this error.
    /// Errors may also refer to all charge_captures present in a Claim Creation, in which case this field will be null.
    /// </summary>
    [JsonPropertyName("charge_capture_id")]
    public string? ChargeCaptureId { get; set; }

    /// <summary>
    /// A human readable error explaining why this charge capture Claim Creation failed to create a claim.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// Whether or not the error has been resolved as part of user workflows
    /// </summary>
    [JsonPropertyName("resolved")]
    public bool? Resolved { get; set; }

    /// <summary>
    /// A string denoting who resolved the error within candid's system.
    /// </summary>
    [JsonPropertyName("resolved_by")]
    public string? ResolvedBy { get; set; }

    /// <summary>
    /// A string denoting how or why an error was resolved.
    /// </summary>
    [JsonPropertyName("resolution_reason")]
    public string? ResolutionReason { get; set; }

    /// <summary>
    /// The field of the corresponding underlying ChargeCapture that has a field that is failing validations,
    /// is not present but marked as required, or otherwise in error.
    /// </summary>
    [JsonPropertyName("field_in_error")]
    public string? FieldInError { get; set; }

    /// <summary>
    /// The ID of the ChargeCaptureClaimCreation associated with this Error.
    /// </summary>
    [JsonPropertyName("claim_creation_id")]
    public required string ClaimCreationId { get; set; }

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
