using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.WriteOffs.V1;

public record PatientWriteOffCreate
{
    [JsonPropertyName("write_off_timestamp")]
    public required DateTime WriteOffTimestamp { get; set; }

    [JsonPropertyName("write_off_note")]
    public string? WriteOffNote { get; set; }

    [JsonPropertyName("write_off_reason")]
    public required PatientWriteOffReason WriteOffReason { get; set; }

    [JsonPropertyName("service_line_id")]
    public required string ServiceLineId { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }
}
