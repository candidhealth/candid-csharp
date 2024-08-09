using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record Lab
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("code_type")]
    public LabCodeType? CodeType { get; set; }
}
