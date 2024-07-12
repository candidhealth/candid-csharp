using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Contracts.V2;

public record ContractIsLinkedToFeeScheduleError
{
    [JsonPropertyName("message")]
    public required string Message { get; init; }
}
