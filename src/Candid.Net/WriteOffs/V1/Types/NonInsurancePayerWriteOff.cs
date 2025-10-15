using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.NonInsurancePayers.V1;

namespace Candid.Net.WriteOffs.V1;

[Serializable]
public record NonInsurancePayerWriteOff : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("write_off_id")]
    public required string WriteOffId { get; set; }

    [JsonPropertyName("non_insurance_payer")]
    public required NonInsurancePayer NonInsurancePayer { get; set; }

    [JsonPropertyName("service_line_id")]
    public required string ServiceLineId { get; set; }

    [JsonPropertyName("write_off_timestamp")]
    public required DateTime WriteOffTimestamp { get; set; }

    [JsonPropertyName("write_off_note")]
    public string? WriteOffNote { get; set; }

    [JsonPropertyName("write_off_reason")]
    public required InsuranceWriteOffReason WriteOffReason { get; set; }

    [JsonPropertyName("reverts_write_off_id")]
    public string? RevertsWriteOffId { get; set; }

    [JsonPropertyName("reverted_by_write_off_id")]
    public string? RevertedByWriteOffId { get; set; }

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
