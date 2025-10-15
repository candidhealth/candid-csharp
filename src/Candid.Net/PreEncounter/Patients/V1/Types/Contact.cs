using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Common;

namespace Candid.Net.PreEncounter.Patients.V1;

[Serializable]
public record Contact : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("relationship")]
    public IEnumerable<Relationship> Relationship { get; set; } = new List<Relationship>();

    [JsonPropertyName("name")]
    public required HumanName Name { get; set; }

    [JsonPropertyName("telecoms")]
    public IEnumerable<ContactPoint> Telecoms { get; set; } = new List<ContactPoint>();

    [JsonPropertyName("addresses")]
    public IEnumerable<global::Candid.Net.PreEncounter.Common.Address> Addresses { get; set; } =
        new List<global::Candid.Net.PreEncounter.Common.Address>();

    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    [JsonPropertyName("hipaa_authorization")]
    public bool? HipaaAuthorization { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
