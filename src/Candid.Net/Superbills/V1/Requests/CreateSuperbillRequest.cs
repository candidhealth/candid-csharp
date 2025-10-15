using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.Superbills.V1;

[Serializable]
public record CreateSuperbillRequest
{
    /// <summary>
    /// Empty string not allowed
    /// </summary>
    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; set; }

    /// <summary>
    /// Minimum (inclusive) date selected for the superbill
    /// </summary>
    [JsonPropertyName("date_range_min")]
    public required DateOnly DateRangeMin { get; set; }

    /// <summary>
    /// Maximum (inclusive) date selected for the superbill
    /// </summary>
    [JsonPropertyName("date_range_max")]
    public required DateOnly DateRangeMax { get; set; }

    /// <summary>
    /// Address that will be displayed on the superbill as the 'Pay to' Address. If not provided this value will be set from available encounter data.
    /// </summary>
    [JsonPropertyName("pay_to_address")]
    public StreetAddressShortZip? PayToAddress { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
