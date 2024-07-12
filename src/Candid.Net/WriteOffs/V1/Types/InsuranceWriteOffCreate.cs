using System.Text.Json.Serialization;
using Candid.Net.WriteOffs.V1;

#nullable enable

namespace Candid.Net.WriteOffs.V1;

public record InsuranceWriteOffCreate
{
    [JsonPropertyName("payer_identifier")]
    public required object PayerIdentifier { get; init; }

    [JsonPropertyName("write_off_target")]
    public required object WriteOffTarget { get; init; }

    [JsonPropertyName("write_off_timestamp")]
    public required DateTime WriteOffTimestamp { get; init; }

    [JsonPropertyName("write_off_note")]
    public string? WriteOffNote { get; init; }

    [JsonPropertyName("write_off_reason")]
    public required InsuranceWriteOffReason WriteOffReason { get; init; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; init; }
}
