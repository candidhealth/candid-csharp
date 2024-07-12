using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record RequestValidationError
{
    [JsonPropertyName("fieldName")]
    public required string FieldName { get; init; }

    [JsonPropertyName("humanReadableMessage")]
    public string? HumanReadableMessage { get; init; }
}
