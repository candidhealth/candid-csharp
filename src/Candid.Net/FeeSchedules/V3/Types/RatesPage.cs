using System.Text.Json.Serialization;
using Candid.Net.FeeSchedules.V3;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record RatesPage
{
    [JsonPropertyName("rates")]
    public IEnumerable<Rate> Rates { get; set; } = new List<Rate>();
}
