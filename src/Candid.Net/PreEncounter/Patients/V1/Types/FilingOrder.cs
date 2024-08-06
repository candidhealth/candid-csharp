using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public record FilingOrder
{
    [JsonPropertyName("coverages")]
    public IEnumerable<string> Coverages { get; set; } = new List<string>();
}
