using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.CustomSchemas.V1;

public record KeyWithNameAlreadyExistsError
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("value_type")]
    public required Primitive ValueType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
