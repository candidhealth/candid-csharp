using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public record PatientNonInsurancePayerInfoCreate
{
    [JsonPropertyName("non_insurance_payer_id")]
    public required string NonInsurancePayerId { get; set; }

    [JsonPropertyName("member_id")]
    public string? MemberId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
