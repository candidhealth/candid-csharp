using System.Text.Json.Serialization;
using Candid.Net.WriteOffs.V1;

#nullable enable

namespace Candid.Net.WriteOffs.V1;

public record PatientWriteOffCreate
{
    [JsonPropertyName("write_off_timestamp")]
    public required DateTime WriteOffTimestamp { get; init; }

    [JsonPropertyName("write_off_note")]
    public string? WriteOffNote { get; init; }

    [JsonPropertyName("write_off_reason")]
    public required PatientWriteOffReason WriteOffReason { get; init; }

    [JsonPropertyName("service_line_id")]
    public required Guid ServiceLineId { get; init; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; init; }
}
