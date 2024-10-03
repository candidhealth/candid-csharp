using System.Text.Json.Serialization;
using Candid.Net.Core;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
