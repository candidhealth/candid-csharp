using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.NonInsurancePayers.V1;

#nullable enable

namespace Candid.Net;

public record PatientNonInsurancePayerInfo
{
    [JsonPropertyName("non_insurance_payer")]
    public required NonInsurancePayer NonInsurancePayer { get; set; }

    [JsonPropertyName("member_id")]
    public string? MemberId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
