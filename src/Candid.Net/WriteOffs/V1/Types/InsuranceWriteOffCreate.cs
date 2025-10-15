using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.Payers.V3;

namespace Candid.Net.WriteOffs.V1;

[Serializable]
public record InsuranceWriteOffCreate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("payer_identifier")]
    public required PayerIdentifier PayerIdentifier { get; set; }

    [JsonPropertyName("write_off_target")]
    public required InsuranceWriteOffTarget WriteOffTarget { get; set; }

    [JsonPropertyName("write_off_timestamp")]
    public required DateTime WriteOffTimestamp { get; set; }

    [JsonPropertyName("write_off_note")]
    public string? WriteOffNote { get; set; }

    [JsonPropertyName("write_off_reason")]
    public required InsuranceWriteOffReason WriteOffReason { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

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
