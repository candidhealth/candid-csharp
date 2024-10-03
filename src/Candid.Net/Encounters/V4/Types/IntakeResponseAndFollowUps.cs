using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record IntakeResponseAndFollowUps
{
    [JsonPropertyName("response")]
    public string? Response { get; set; }

    [JsonPropertyName("follow_ups")]
    public IEnumerable<IntakeFollowUp>? FollowUps { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
