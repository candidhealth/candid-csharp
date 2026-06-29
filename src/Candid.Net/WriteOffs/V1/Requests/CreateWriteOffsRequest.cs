using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

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
