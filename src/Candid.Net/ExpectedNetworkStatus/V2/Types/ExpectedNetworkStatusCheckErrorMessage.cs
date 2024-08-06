using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

public record ExpectedNetworkStatusCheckErrorMessage
{
    [JsonPropertyName("message")]
    public required string Message { get; set; }
}
