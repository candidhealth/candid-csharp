using System.Text.Json.Serialization;
using Candid.Net.Tasks.V3;

#nullable enable

namespace Candid.Net.Tasks.V3;

public record TaskActions
{
    [JsonPropertyName("actions")]
    public IEnumerable<TaskAction> Actions { get; set; } = new List<TaskAction>();
}
