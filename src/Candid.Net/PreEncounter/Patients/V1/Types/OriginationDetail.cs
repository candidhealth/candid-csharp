using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Common;

namespace Candid.Net.PreEncounter.Patients.V1;

[Serializable]
public record OriginationDetail : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("referral_source")]
    public required ReferralSource ReferralSource { get; set; }

    [JsonPropertyName("referring_provider")]
    public ExternalProvider? ReferringProvider { get; set; }

    [JsonPropertyName("specialization_categories")]
    public IEnumerable<SpecializationCategory>? SpecializationCategories { get; set; }

    [JsonPropertyName("referral_type")]
    public ReferralType? ReferralType { get; set; }

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
