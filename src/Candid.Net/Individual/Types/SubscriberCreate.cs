using System.Text.Json.Serialization;
using Candid.Net.InsuranceCards.V2;

#nullable enable

namespace Candid.Net;

public record SubscriberCreate
{
    [JsonPropertyName("insurance_card")]
    public required InsuranceCardCreate InsuranceCard { get; set; }
}
