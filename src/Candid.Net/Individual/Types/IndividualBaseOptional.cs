using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Individual;

public record IndividualBaseOptional
{
    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("gender")]
    public Gender? Gender { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
