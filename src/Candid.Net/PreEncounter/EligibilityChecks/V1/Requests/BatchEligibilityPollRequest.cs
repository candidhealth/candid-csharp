using System.Text.Json.Serialization;
using Candid.Net.Core;

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
