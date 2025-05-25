using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public record EligibilityCheckErrorDetails
{
    [JsonPropertyName("field?")]
    public string? Field { get; set; }

    [JsonPropertyName("description?")]
    public string? Description { get; set; }

    [JsonPropertyName("location?")]
    public string? Location { get; set; }

    [JsonPropertyName("possibleResolutions?")]
    public string? PossibleResolutions { get; set; }

    [JsonPropertyName("code?")]
    public string? Code { get; set; }

    [JsonPropertyName("followupAction?")]
    public string? FollowupAction { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
