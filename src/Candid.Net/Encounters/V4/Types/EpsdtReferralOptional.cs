using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[Serializable]
public record EpsdtReferralOptional : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("condition_indicator1")]
    public EpsdtReferralConditionIndicatorCode? ConditionIndicator1 { get; set; }

    [JsonPropertyName("condition_indicator2")]
    public EpsdtReferralConditionIndicatorCode? ConditionIndicator2 { get; set; }

    [JsonPropertyName("condition_indicator3")]
    public EpsdtReferralConditionIndicatorCode? ConditionIndicator3 { get; set; }

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
