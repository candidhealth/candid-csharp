using System.Text.Json.Serialization;
using Candid.Net.Tasks.V3;

#nullable enable

namespace Candid.Net.Tasks.V3;

public record TaskPage
{
    [JsonPropertyName("items")]
    public IEnumerable<Task> Items { get; set; } = new List<Task>();
}
