using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Payers.V4;

public record Payer
{
    /// <summary>
    /// Auto-generated ID set on creation.
    /// </summary>
    [JsonPropertyName("payer_uuid")]
    public required string PayerUuid { get; set; }

    /// <summary>
    /// The primary national payer IDs of the payer.
    /// </summary>
    [JsonPropertyName("payer_ids")]
    public required PayerIds PayerIds { get; set; }

    /// <summary>
    /// The primary display name of the payer.
    /// </summary>
    [JsonPropertyName("payer_name")]
    public required string PayerName { get; set; }

    [JsonPropertyName("clearinghouse_payer_info")]
    public Dictionary<Clearinghouse, ClearinghousePayerInfo> ClearinghousePayerInfo { get; set; } =
        new Dictionary<Clearinghouse, ClearinghousePayerInfo>();

    [JsonPropertyName("street_address")]
    public StreetAddressLongZip? StreetAddress { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
