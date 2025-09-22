using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Common;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public record OriginationDetail
{
    [JsonPropertyName("referral_source")]
    public required ReferralSource ReferralSource { get; set; }

    [JsonPropertyName("referring_provider")]
    public ExternalProvider? ReferringProvider { get; set; }

    [JsonPropertyName("specialization_categories")]
    public IEnumerable<SpecializationCategory>? SpecializationCategories { get; set; }

    [JsonPropertyName("referral_type")]
    public ReferralType? ReferralType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
