using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter;

public record VersionConflictErrorBody
{
    [JsonPropertyName("code")]
    public required string Code { get; init; }

    [JsonPropertyName("latestVersion")]
    public required int LatestVersion { get; init; }

    [JsonPropertyName("message")]
    public required string Message { get; init; }
}
