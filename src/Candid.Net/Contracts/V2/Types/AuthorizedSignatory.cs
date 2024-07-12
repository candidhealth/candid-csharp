using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Contracts.V2;

public record AuthorizedSignatory
{
    [JsonPropertyName("first_name")]
    public string? FirstName { get; init; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; init; }

    [JsonPropertyName("title")]
    public string? Title { get; init; }

    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonPropertyName("phone")]
    public string? Phone { get; init; }

    [JsonPropertyName("fax")]
    public string? Fax { get; init; }
}
