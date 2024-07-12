using System.Text.Json.Serialization;
using Candid.Net.Tasks.V3;

#nullable enable

namespace Candid.Net.Tasks.V3;

public record TaskAction
{
    [JsonPropertyName("display_name")]
    public required string DisplayName { get; init; }

    [JsonPropertyName("execution_method")]
    public required object ExecutionMethod { get; init; }

    [JsonPropertyName("type")]
    public required TaskActionType Type { get; init; }
}
