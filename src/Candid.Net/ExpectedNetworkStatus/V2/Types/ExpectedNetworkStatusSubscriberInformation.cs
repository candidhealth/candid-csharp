using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.ExpectedNetworkStatus.V2;

[Serializable]
public record ExpectedNetworkStatusSubscriberInformation : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The UUID that corresponds with the payer on the patient’s insurance card
    /// </summary>
    [JsonPropertyName("payer_uuid")]
    public required string PayerUuid { get; set; }

    /// <summary>
    /// The member_id on the patient’s insurance card
    /// </summary>
    [JsonPropertyName("member_id")]
    public required string MemberId { get; set; }

    /// <summary>
    /// The insurance information on the patient's insurance card
    /// </summary>
    [JsonPropertyName("insurance_type")]
    public required InsuranceType InsuranceType { get; set; }

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
