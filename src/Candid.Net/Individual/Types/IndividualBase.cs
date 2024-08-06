using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net;

public record IndividualBase
{
    [JsonPropertyName("first_name")]
    public required string FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public required string LastName { get; set; }

    [JsonPropertyName("gender")]
    public required Gender Gender { get; set; }
}
