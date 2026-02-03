using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Financials;

/// <summary>
/// Represents an active balance earmarking record that holds allocated funds for future auto-allocation.
/// Earmarks are created when funds are allocated but should be held for a specific encounter or date of service.
/// Only active (non-deleted) earmarks are returned.
/// </summary>
[Serializable]
public record BalanceEarmark : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The target for this earmark (date of service or external encounter ID)
    /// </summary>
    [JsonPropertyName("target")]
    public required AllocationEarmarkType Target { get; set; }

    /// <summary>
    /// The amount earmarked in cents for future allocation
    /// </summary>
    [JsonPropertyName("amount_earmarked_cents")]
    public int? AmountEarmarkedCents { get; set; }

    /// <summary>
    /// The ID of the allocation that created this earmark
    /// </summary>
    [JsonPropertyName("created_by_allocation_id")]
    public string? CreatedByAllocationId { get; set; }

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
