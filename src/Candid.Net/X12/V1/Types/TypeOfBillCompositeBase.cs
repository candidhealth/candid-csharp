using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.X12.V1;

public record TypeOfBillCompositeBase
{
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
