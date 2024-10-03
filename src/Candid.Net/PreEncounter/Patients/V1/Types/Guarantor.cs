using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public record Guarantor
{
    [JsonPropertyName("name")]
    public required HumanName Name { get; set; }

    [JsonPropertyName("telecom")]
    public required ContactPoint Telecom { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("birth_date")]
    public required DateOnly BirthDate { get; set; }

    [JsonPropertyName("address")]
    public required Address Address { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
