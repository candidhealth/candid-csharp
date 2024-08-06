using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record UpdatesDisabledDueToExternalSystemIntegrationErrorMessage
{
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}
