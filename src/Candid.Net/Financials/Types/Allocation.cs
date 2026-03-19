using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.Financials;

[Serializable]
public record Allocation : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonPropertyName("target")]
    public required AllocationTarget Target { get; set; }

    /// <summary>
    /// The active earmark created by this allocation, if any. Only present when this allocation created an earmark for future auto-allocation and the earmark has not been deleted.
    /// </summary>
    [JsonPropertyName("earmark")]
    public BalanceEarmark? Earmark { get; set; }

    [JsonPropertyName("allocated_on")]
    public DateTime? AllocatedOn { get; set; }

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
