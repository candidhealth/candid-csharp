using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record EligibilityCheckMetadata
{
    [JsonPropertyName("check_id")]
    public required string CheckId { get; set; }

    [JsonPropertyName("service_code")]
    public required ServiceTypeCode ServiceCode { get; set; }

    [JsonPropertyName("status")]
    public required EligibilityCheckStatus Status { get; set; }

    [JsonPropertyName("initiated_by")]
    public required string InitiatedBy { get; set; }

    [JsonPropertyName("initiated_at")]
    public required DateTime InitiatedAt { get; set; }
}