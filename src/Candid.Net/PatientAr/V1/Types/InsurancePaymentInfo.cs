using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PatientAr.V1;

public record InsurancePaymentInfo
{
    /// <summary>
    /// The total amount of insurance payments in cents for the service line.
    /// </summary>
    [JsonPropertyName("total_payment_cents")]
    public required int TotalPaymentCents { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
