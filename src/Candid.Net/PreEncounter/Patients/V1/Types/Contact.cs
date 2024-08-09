using System.Text.Json.Serialization;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public record Contact
{
    [JsonPropertyName("relationship")]
    public IEnumerable<Relationship> Relationship { get; set; } = new List<Relationship>();

    [JsonPropertyName("name")]
    public required HumanName Name { get; set; }

    [JsonPropertyName("telecoms")]
    public IEnumerable<ContactPoint> Telecoms { get; set; } = new List<ContactPoint>();

    [JsonPropertyName("addresses")]
    public IEnumerable<Address> Addresses { get; set; } = new List<Address>();

    [JsonPropertyName("period")]
    public Period? Period { get; set; }
}
