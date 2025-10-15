using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.Financials;
using Candid.Net.Payers.V3;

namespace Candid.Net.InsuranceRefunds.V1;

[Serializable]
public record InsuranceRefundCreate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("payer_identifier")]
    public required PayerIdentifier PayerIdentifier { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonPropertyName("refund_timestamp")]
    public DateTime? RefundTimestamp { get; set; }

    [JsonPropertyName("refund_note")]
    public string? RefundNote { get; set; }

    [JsonPropertyName("allocations")]
    public IEnumerable<AllocationCreate> Allocations { get; set; } = new List<AllocationCreate>();

    [JsonPropertyName("refund_reason")]
    public RefundReason? RefundReason { get; set; }

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
