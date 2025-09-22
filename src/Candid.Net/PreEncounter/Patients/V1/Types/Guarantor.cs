using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Common;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public record Guarantor
{
    [JsonPropertyName("name")]
    public required HumanName Name { get; set; }

    [JsonPropertyName("telecom")]
    public ContactPoint? Telecom { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("birth_date")]
    public DateOnly? BirthDate { get; set; }

    [JsonPropertyName("address")]
    public required Common.Address Address { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
