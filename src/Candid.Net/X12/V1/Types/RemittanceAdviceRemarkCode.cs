using System.Text.Json.Serialization;
using Candid.Net.X12.V1;

#nullable enable

namespace Candid.Net.X12.V1;

public record RemittanceAdviceRemarkCode
{
    [JsonPropertyName("reason_code")]
    public required Rarc ReasonCode { get; init; }
}
