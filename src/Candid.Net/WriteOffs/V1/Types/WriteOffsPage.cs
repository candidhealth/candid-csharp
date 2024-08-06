using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.WriteOffs.V1;

public record WriteOffsPage
{
    [JsonPropertyName("items")]
    public IEnumerable<object> Items { get; set; } = new List<object>();
}
