using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PatientAr.V1;

public record NonInsuranceAdjustmentInfo
{
    /// <summary>
    /// The total amount of non-insurance adjustments in cents for the service line.
    /// </summary>
    [JsonPropertyName("total_adjustment_cents")]
    public required int TotalAdjustmentCents { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
