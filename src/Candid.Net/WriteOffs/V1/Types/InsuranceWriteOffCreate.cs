using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.WriteOffs.V1;

public record InsuranceWriteOffCreate
{
    [JsonPropertyName("payer_identifier")]
    public required object PayerIdentifier { get; set; }

    [JsonPropertyName("write_off_target")]
    public required object WriteOffTarget { get; set; }

    [JsonPropertyName("write_off_timestamp")]
    public required DateTime WriteOffTimestamp { get; set; }

    [JsonPropertyName("write_off_note")]
    public string? WriteOffNote { get; set; }

    [JsonPropertyName("write_off_reason")]
    public required InsuranceWriteOffReason WriteOffReason { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }
}
