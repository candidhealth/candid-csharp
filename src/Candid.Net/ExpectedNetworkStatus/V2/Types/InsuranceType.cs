using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

public record InsuranceType
{
    /// <summary>
    /// The line of business associated with the patient’s insurance
    /// </summary>
    [JsonPropertyName("line_of_business")]
    public required LineOfBusiness LineOfBusiness { get; set; }

    [JsonPropertyName("insurance_type_codes")]
    public required object InsuranceTypeCodes { get; set; }
}
