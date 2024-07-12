using System.Text.Json.Serialization;
using Candid.Net.WriteOffs.V1;

#nullable enable

namespace Candid.Net.WriteOffs.V1;

public record PatientWriteOff
{
    [JsonPropertyName("write_off_id")]
    public required Guid WriteOffId { get; init; }

    [JsonPropertyName("write_off_timestamp")]
    public required DateTime WriteOffTimestamp { get; init; }

    [JsonPropertyName("write_off_note")]
    public string? WriteOffNote { get; init; }

    [JsonPropertyName("write_off_reason")]
    public required PatientWriteOffReason WriteOffReason { get; init; }

    [JsonPropertyName("service_line_id")]
    public required Guid ServiceLineId { get; init; }

    [JsonPropertyName("reverts_write_off_id")]
    public Guid? RevertsWriteOffId { get; init; }

    [JsonPropertyName("reverted_by_write_off_id")]
    public Guid? RevertedByWriteOffId { get; init; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; init; }
}
