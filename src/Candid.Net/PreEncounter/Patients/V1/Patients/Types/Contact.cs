using System.Text.Json.Serialization;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public record Contact
{
    [JsonPropertyName("relationship")]
    public IEnumerable<Relationship> Relationship { get; init; } = new List<Relationship>();

    [JsonPropertyName("name")]
    public required HumanName Name { get; init; }

    [JsonPropertyName("gender")]
    public Gender? Gender { get; init; }

    [JsonPropertyName("telecoms")]
    public IEnumerable<ContactPoint> Telecoms { get; init; } = new List<ContactPoint>();

    [JsonPropertyName("addresses")]
    public IEnumerable<Address> Addresses { get; init; } = new List<Address>();

    [JsonPropertyName("period")]
    public Period? Period { get; init; }
}
