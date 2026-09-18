using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

[Serializable]
public record EncounterEligibility : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("source")]
    public required EligibilitySource Source { get; set; }

    [JsonPropertyName("dateOfService")]
    public required DateTime DateOfService { get; set; }

    [JsonPropertyName("payerId")]
    public required string PayerId { get; set; }

    [JsonPropertyName("providerNPI")]
    public required string ProviderNpi { get; set; }

    [JsonPropertyName("dependent")]
    public Dependent? Dependent { get; set; }

    [JsonPropertyName("status")]
    public required EligibilityStatus Status { get; set; }

    [JsonPropertyName("errors")]
    public IEnumerable<EligibilityCheckError> Errors { get; set; } =
        new List<EligibilityCheckError>();

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
