using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Commons;

public record RequestValidationError
{
    [JsonPropertyName("fieldName")]
    public required string FieldName { get; set; }

    [JsonPropertyName("humanReadableMessage")]
    public string? HumanReadableMessage { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
