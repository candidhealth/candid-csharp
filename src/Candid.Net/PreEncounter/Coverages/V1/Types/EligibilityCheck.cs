using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record EligibilityCheck
{
    [JsonPropertyName("raw_json")]
    public required object RawJson { get; set; }
}
