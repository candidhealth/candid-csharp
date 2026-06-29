using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

[Serializable]
public record BatchEligibilityPollRequest
{
    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
