using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record OrganizationNotAuthorizedErrorMessage
{
    [JsonPropertyName("message")]
    public required string Message { get; init; }
}
