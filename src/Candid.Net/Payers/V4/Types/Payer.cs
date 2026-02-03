using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.Payers.V4;

[Serializable]
public record Payer : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Auto-generated ID set on creation.
    /// </summary>
    [JsonPropertyName("payer_uuid")]
    public required string PayerUuid { get; set; }

    /// <summary>
    /// The primary national payer IDs of the payer.
    /// </summary>
    [JsonPropertyName("payer_ids")]
    public required PrimaryPayerIds PayerIds { get; set; }

    /// <summary>
    /// The primary display name of the payer.
    /// </summary>
    [JsonPropertyName("payer_name")]
    public required string PayerName { get; set; }

    /// <summary>
    /// The alternate display names of the payer.
    /// </summary>
    [JsonPropertyName("alternate_payer_names")]
    public IEnumerable<string> AlternatePayerNames { get; set; } = new List<string>();

    [JsonPropertyName("clearinghouse_payer_info")]
    public Dictionary<Clearinghouse, ClearinghousePayerInfo> ClearinghousePayerInfo { get; set; } =
        new Dictionary<Clearinghouse, ClearinghousePayerInfo>();

    [JsonPropertyName("street_address")]
    public StreetAddressLongZip? StreetAddress { get; set; }

    [JsonPropertyName("alternate_payer_addresses")]
    public IEnumerable<StreetAddressLongZip> AlternatePayerAddresses { get; set; } =
        new List<StreetAddressLongZip>();

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
