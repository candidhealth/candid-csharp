using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PatientAr.V1;

public record PatientPaymentInfo
{
    /// <summary>
    /// The total amount of patient payments in cents for the service line.
    /// </summary>
    [JsonPropertyName("total_payment_cents")]
    public required int TotalPaymentCents { get; set; }

    /// <summary>
    /// A list of patient payment items associated with the service line.
    /// </summary>
    [JsonPropertyName("items")]
    public IEnumerable<PatientPaymentAllocation> Items { get; set; } =
        new List<PatientPaymentAllocation>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
