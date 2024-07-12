using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.WriteOffs.V1;

public record CreateWriteOffsRequest
{
    [JsonPropertyName("write_offs")]
    public IEnumerable<object> WriteOffs { get; init; } = new List<object>();
}
