using global::Candid.Net;
using global::Candid.Net.Core;
using global::Candid.Net.PreEncounter.EligibilityChecks.V1;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Patients.V1;

[Serializable]
public record AuditEligCheckCompleted : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("check_id")]
    public required string CheckId { get; set; }

    [JsonPropertyName("coverage_id")]
    public required string CoverageId { get; set; }

    [JsonPropertyName("coverage_type")]
    public CoverageType? CoverageType { get; set; }

    [JsonPropertyName("appointment_id")]
    public string? AppointmentId { get; set; }

    [JsonPropertyName("run_id")]
    public string? RunId { get; set; }

    [JsonPropertyName("status")]
    public required EligibilityCheckStatus Status { get; set; }

    [JsonPropertyName("payer_id")]
    public string? PayerId { get; set; }

    [JsonPropertyName("payer_name")]
    public string? PayerName { get; set; }

    [JsonPropertyName("eligibility_status")]
    public global::Candid.Net.PreEncounter.EligibilityChecks.V1.EligibilityStatus? EligibilityStatus { get; set; }

    [JsonPropertyName("error_code")]
    public string? ErrorCode { get; set; }

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
