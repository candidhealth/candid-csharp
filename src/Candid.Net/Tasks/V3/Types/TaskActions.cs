using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Tasks.V3;

public record TaskActions
{
    [JsonPropertyName("actions")]
    public IEnumerable<TaskAction> Actions { get; set; } = new List<TaskAction>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
