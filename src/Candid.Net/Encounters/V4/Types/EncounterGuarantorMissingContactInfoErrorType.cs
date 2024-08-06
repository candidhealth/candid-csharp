using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record EncounterGuarantorMissingContactInfoErrorType
{
    [JsonPropertyName("missing_fields")]
    public IEnumerable<string> MissingFields { get; set; } = new List<string>();
}
