using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.InsuranceCards.V2;

[Serializable]
public record InsuranceCardCreateOptional : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("member_id")]
    public string? MemberId { get; set; }

    [JsonPropertyName("payer_name")]
    public string? PayerName { get; set; }

    [JsonPropertyName("payer_id")]
    public string? PayerId { get; set; }

    [JsonPropertyName("rx_bin")]
    public string? RxBin { get; set; }

    [JsonPropertyName("rx_pcn")]
    public string? RxPcn { get; set; }

    [JsonPropertyName("image_url_front")]
    public string? ImageUrlFront { get; set; }

    [JsonPropertyName("image_url_back")]
    public string? ImageUrlBack { get; set; }

    [JsonPropertyName("emr_payer_crosswalk")]
    public EmrPayerCrosswalk? EmrPayerCrosswalk { get; set; }

    /// <summary>
    /// Box 11 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("group_number")]
    public string? GroupNumber { get; set; }

    /// <summary>
    /// Box 11c on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("plan_name")]
    public string? PlanName { get; set; }

    [JsonPropertyName("plan_type")]
    public SourceOfPaymentCode? PlanType { get; set; }

    [JsonPropertyName("insurance_type")]
    public Candid.Net.Commons.InsuranceTypeCode? InsuranceType { get; set; }

    [JsonPropertyName("payer_plan_group_id")]
    public string? PayerPlanGroupId { get; set; }

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
