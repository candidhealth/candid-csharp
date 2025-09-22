using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Common;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public record Referral
{
    [JsonPropertyName("provider")]
    public required ExternalProvider Provider { get; set; }

    [JsonPropertyName("referral_number")]
    public required string ReferralNumber { get; set; }

    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
