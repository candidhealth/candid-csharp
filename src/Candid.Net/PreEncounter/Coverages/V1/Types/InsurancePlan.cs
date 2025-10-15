using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Common;

namespace Candid.Net.PreEncounter.Coverages.V1;

[Serializable]
public record InsurancePlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("member_id")]
    public required string MemberId { get; set; }

    [JsonPropertyName("payer_id")]
    public required string PayerId { get; set; }

    [JsonPropertyName("payer_name")]
    public required string PayerName { get; set; }

    [JsonPropertyName("additional_payer_information")]
    public AdditionalPayerInformation? AdditionalPayerInformation { get; set; }

    [JsonPropertyName("group_number")]
    public string? GroupNumber { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("plan_type")]
    public NetworkType? PlanType { get; set; }

    [JsonPropertyName("type")]
    public InsuranceTypeCode? Type { get; set; }

    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    [JsonPropertyName("insurance_card_image_locator")]
    public string? InsuranceCardImageLocator { get; set; }

    /// <summary>
    /// The ID of the Candid configured payer plan group associated with this coverage
    /// </summary>
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
