using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Common;

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
    public IEnumerable<Common.Address> Addresses { get; set; } = new List<Common.Address>();

    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    [JsonPropertyName("hipaa_authorization")]
    public bool? HipaaAuthorization { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
