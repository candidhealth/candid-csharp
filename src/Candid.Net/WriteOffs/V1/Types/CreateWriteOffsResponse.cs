using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.WriteOffs.V1;

public record CreateWriteOffsResponse
{
    [JsonPropertyName("write_offs")]
    public IEnumerable<object> WriteOffs { get; set; } = new List<object>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
