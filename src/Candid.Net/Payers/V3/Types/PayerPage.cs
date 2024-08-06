using System.Text.Json.Serialization;
using Candid.Net.Payers.V3;

#nullable enable

namespace Candid.Net.Payers.V3;

public record PayerPage
{
    [JsonPropertyName("items")]
    public IEnumerable<Payer> Items { get; set; } = new List<Payer>();
}
