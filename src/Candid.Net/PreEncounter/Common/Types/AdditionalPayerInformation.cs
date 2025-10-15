using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Common;

[Serializable]
public record AdditionalPayerInformation : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("availity_eligibility_id")]
    public string? AvailityEligibilityId { get; set; }

    [JsonPropertyName("availity_payer_id")]
    public string? AvailityPayerId { get; set; }

    [JsonPropertyName("availity_payer_name")]
    public string? AvailityPayerName { get; set; }

    [JsonPropertyName("availity_remittance_payer_id")]
    public string? AvailityRemittancePayerId { get; set; }

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
