using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter;

public record VersionConflictErrorBody
{
    [JsonPropertyName("latest_version")]
    public int? LatestVersion { get; set; }

    [JsonPropertyName("message")]
    public required string Message { get; set; }

    [JsonPropertyName("data")]
    public object? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
