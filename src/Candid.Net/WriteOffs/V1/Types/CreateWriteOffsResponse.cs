using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.WriteOffs.V1;

public record CreateWriteOffsResponse
{
    [JsonPropertyName("write_offs")]
    public IEnumerable<object> WriteOffs { get; set; } = new List<object>();
}
