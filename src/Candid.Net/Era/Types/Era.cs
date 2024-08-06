using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record Era
{
    [JsonPropertyName("era_id")]
    public required string EraId { get; set; }
}
