using System.Text.Json.Serialization;
using Candid.Net.InsuranceCards.V2;

#nullable enable

namespace Candid.Net;

public record Subscriber
{
    [JsonPropertyName("individual_id")]
    public required string IndividualId { get; set; }

    [JsonPropertyName("insurance_card")]
    public required InsuranceCard InsuranceCard { get; set; }
}
