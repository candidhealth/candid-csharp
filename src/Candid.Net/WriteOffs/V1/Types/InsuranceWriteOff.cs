using System.Text.Json.Serialization;
using Candid.Net.Payers.V3;
using Candid.Net.WriteOffs.V1;

#nullable enable

namespace Candid.Net.WriteOffs.V1;

public record InsuranceWriteOff
{
    [JsonPropertyName("write_off_id")]
    public required Guid WriteOffId { get; init; }

    [JsonPropertyName("payer")]
    public required Payer Payer { get; init; }

    [JsonPropertyName("write_off_target")]
    public required object WriteOffTarget { get; init; }

    [JsonPropertyName("write_off_timestamp")]
    public required DateTime WriteOffTimestamp { get; init; }

    [JsonPropertyName("write_off_note")]
    public string? WriteOffNote { get; init; }

    [JsonPropertyName("write_off_reason")]
    public required InsuranceWriteOffReason WriteOffReason { get; init; }

    [JsonPropertyName("reverts_write_off_id")]
    public Guid? RevertsWriteOffId { get; init; }

    [JsonPropertyName("reverted_by_write_off_id")]
    public Guid? RevertedByWriteOffId { get; init; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; init; }
}
