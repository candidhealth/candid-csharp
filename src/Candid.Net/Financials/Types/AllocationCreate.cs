using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Financials;

/// <summary>
/// Allocations are portions of payments that are applied to specific resources, known as targets. Each allocation has
/// and amount, defined in cents, and a target.
/// </summary>
[Serializable]
public record AllocationCreate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonPropertyName("target")]
    public required AllocationTargetCreate Target { get; set; }

    /// <summary>
    /// If enabled for your organization, optional earmarking configuration for patient prepayments.
    /// When provided on unattributed allocations, holds the payment for future auto-allocation to matching encounters.
    /// </summary>
    [JsonPropertyName("earmark")]
    public AllocationEarmarkType? Earmark { get; set; }

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
