using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Tasks.V3;

public record TaskAction
{
    [JsonPropertyName("display_name")]
    public required string DisplayName { get; set; }

    [JsonPropertyName("execution_method")]
    public required object ExecutionMethod { get; set; }

    [JsonPropertyName("type")]
    public required TaskActionType Type { get; set; }
}
