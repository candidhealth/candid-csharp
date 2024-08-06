using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter;

public record VersionConflictErrorBody
{
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    [JsonPropertyName("latest_version")]
    public required int LatestVersion { get; set; }
}
