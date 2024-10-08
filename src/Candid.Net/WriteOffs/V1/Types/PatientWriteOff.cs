using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.WriteOffs.V1;

public record PatientWriteOff
{
    [JsonPropertyName("write_off_id")]
    public required string WriteOffId { get; set; }

    [JsonPropertyName("write_off_timestamp")]
    public required DateTime WriteOffTimestamp { get; set; }

    [JsonPropertyName("write_off_note")]
    public string? WriteOffNote { get; set; }

    [JsonPropertyName("write_off_reason")]
    public required PatientWriteOffReason WriteOffReason { get; set; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; set; }

    [JsonPropertyName("claim_id")]
    public required string ClaimId { get; set; }

    [JsonPropertyName("service_line_id")]
    public required string ServiceLineId { get; set; }

    [JsonPropertyName("reverts_write_off_id")]
    public string? RevertsWriteOffId { get; set; }

    [JsonPropertyName("reverted_by_write_off_id")]
    public string? RevertedByWriteOffId { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
