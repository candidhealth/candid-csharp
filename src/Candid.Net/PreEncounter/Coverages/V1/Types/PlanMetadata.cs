using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Coverages.V1;

[Serializable]
public record PlanMetadata : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("payer_name")]
    public string? PayerName { get; set; }

    [JsonPropertyName("insurance_type")]
    public string? InsuranceType { get; set; }

    [JsonPropertyName("insurance_type_code")]
    public string? InsuranceTypeCode { get; set; }

    [JsonPropertyName("plan_name")]
    public string? PlanName { get; set; }

    [JsonPropertyName("member_id")]
    public string? MemberId { get; set; }

    [JsonPropertyName("group_number")]
    public string? GroupNumber { get; set; }

    [JsonPropertyName("start_date")]
    public DateOnly? StartDate { get; set; }

    [JsonPropertyName("end_date")]
    public DateOnly? EndDate { get; set; }

    [JsonPropertyName("plan_dates")]
    public IEnumerable<PlanDate>? PlanDates { get; set; }

    [JsonPropertyName("subscriber")]
    public ExpandedMemberInfo? Subscriber { get; set; }

    [JsonPropertyName("dependent")]
    public ExpandedMemberInfo? Dependent { get; set; }

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
