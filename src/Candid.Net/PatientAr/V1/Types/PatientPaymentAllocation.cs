using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PatientAr.V1;

public record PatientPaymentAllocation
{
    /// <summary>
    /// Payment identifier from the source system (e.g., patient portal, manual entry). Note multiple allocations may exist for a single payment and
    /// thus may share the same source_id.
    /// </summary>
    [JsonPropertyName("source_id")]
    public string? SourceId { get; set; }

    /// <summary>
    /// The amount of the patient payment in cents.
    /// </summary>
    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
