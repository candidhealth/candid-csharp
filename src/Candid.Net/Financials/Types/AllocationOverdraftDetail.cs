using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Financials;

/// <summary>
/// Structured information about an allocation that would be overdrafted.
/// Provides entity-specific details to display in a table format.
/// </summary>
[Serializable]
public record AllocationOverdraftDetail : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The allocation target that would be overdrafted (service_line, claim, unattributed, etc.)
    /// </summary>
    [JsonPropertyName("allocation_target")]
    public required AllocationTarget AllocationTarget { get; set; }

    /// <summary>
    /// The amount in cents that the patient has currently paid toward this target (available to reallocate from)
    /// </summary>
    [JsonPropertyName("patient_paid_amount_cents")]
    public required int PatientPaidAmountCents { get; set; }

    /// <summary>
    /// The current balance in cents on this entity before the reallocation
    /// </summary>
    [JsonPropertyName("current_balance_cents")]
    public required int CurrentBalanceCents { get; set; }

    /// <summary>
    /// The amount in cents by which the reallocation would overdraft (always positive)
    /// </summary>
    [JsonPropertyName("overage_amount_cents")]
    public required int OverageAmountCents { get; set; }

    /// <summary>
    /// A descriptive error message explaining the overdraft condition
    /// </summary>
    [JsonPropertyName("error_message")]
    public required string ErrorMessage { get; set; }

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
