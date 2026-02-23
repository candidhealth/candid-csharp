using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

[Serializable]
public record EligibilityChecksGetMultiRequest
{
    [JsonIgnore]
    public string? PageToken { get; set; }

    [JsonIgnore]
    public int? Limit { get; set; }

    [JsonIgnore]
    public string? SubscriberMemberId { get; set; }

    [JsonIgnore]
    public string? PayerId { get; set; }

    [JsonIgnore]
    public string? ProviderNpi { get; set; }

    [JsonIgnore]
    public string? DateOfService { get; set; }

    [JsonIgnore]
    public DateTime? InitiatedAtMin { get; set; }

    [JsonIgnore]
    public DateTime? InitiatedAtMax { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
