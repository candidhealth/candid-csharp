using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.X12.V1;

[Serializable]
public record TypeOfBillCompositeBase : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The FL04 Institutional type of facility code for the bill.  The second digit of the composite code.
    /// </summary>
    [JsonPropertyName("type_of_facility")]
    public required TypeOfFacilityCode TypeOfFacility { get; set; }

    /// <summary>
    /// The FL04 Institutional type of care code for the bill.  The third digit of the composite code.
    /// </summary>
    [JsonPropertyName("type_of_care")]
    public required TypeOfCareCode TypeOfCare { get; set; }

    /// <summary>
    /// The FL04 Institutional frequency code for the bill.  The fourth digit of the composite code.
    /// </summary>
    [JsonPropertyName("frequency_code")]
    public required TypeOfBillFrequencyCode FrequencyCode { get; set; }

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
