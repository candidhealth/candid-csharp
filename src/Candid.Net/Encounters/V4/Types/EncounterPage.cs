using System.Text.Json.Serialization;
using Candid.Net.Encounters.V4;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record EncounterPage
{
    [JsonPropertyName("items")]
    public IEnumerable<Encounter> Items { get; set; } = new List<Encounter>();
}
