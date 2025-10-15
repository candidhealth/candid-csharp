using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.WriteOffs.V1;

[Serializable]
public record CreateWriteOffsRequest
{
    [JsonPropertyName("write_offs")]
    public IEnumerable<WriteOffCreate> WriteOffs { get; set; } = new List<WriteOffCreate>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
