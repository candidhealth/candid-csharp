using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record ValueDoesNotMatchKeyTypeError
{
    [JsonPropertyName("schema_id")]
    public required string SchemaId { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("expected_value_type")]
    public required Primitive ExpectedValueType { get; set; }

    [JsonPropertyName("value")]
    public required object Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
