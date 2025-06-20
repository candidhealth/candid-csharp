using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record IntakeQuestionOptional
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("text")]
    public string? Text { get; set; }

    [JsonPropertyName("responses")]
    public IEnumerable<IntakeResponseAndFollowUps>? Responses { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
