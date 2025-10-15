using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.PayerPlanGroups.V1;

[Serializable]
public record MutablePayerPlanGroup : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("plan_group_name")]
    public required string PlanGroupName { get; set; }

    [JsonPropertyName("payer_uuid")]
    public required string PayerUuid { get; set; }

    [JsonPropertyName("plan_type")]
    public required SourceOfPaymentCode PlanType { get; set; }

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
