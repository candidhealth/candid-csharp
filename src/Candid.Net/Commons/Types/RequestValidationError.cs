using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record RequestValidationError
{
    [JsonPropertyName("fieldName")]
    public required string FieldName { get; set; }

    [JsonPropertyName("humanReadableMessage")]
    public string? HumanReadableMessage { get; set; }
}
