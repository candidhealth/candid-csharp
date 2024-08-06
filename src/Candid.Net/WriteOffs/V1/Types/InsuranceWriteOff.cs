using System.Text.Json.Serialization;
using Candid.Net.Payers.V3;
using Candid.Net.WriteOffs.V1;

#nullable enable

namespace Candid.Net.WriteOffs.V1;

public record InsuranceWriteOff
{
    [JsonPropertyName("write_off_id")]
    public required string WriteOffId { get; set; }

    [JsonPropertyName("payer")]
    public required Payer Payer { get; set; }

    [JsonPropertyName("write_off_target")]
    public required object WriteOffTarget { get; set; }

    [JsonPropertyName("write_off_timestamp")]
    public required DateTime WriteOffTimestamp { get; set; }

    [JsonPropertyName("write_off_note")]
    public string? WriteOffNote { get; set; }

    [JsonPropertyName("write_off_reason")]
    public required InsuranceWriteOffReason WriteOffReason { get; set; }

    [JsonPropertyName("reverts_write_off_id")]
    public string? RevertsWriteOffId { get; set; }

    [JsonPropertyName("reverted_by_write_off_id")]
    public string? RevertedByWriteOffId { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }
}
