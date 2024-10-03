using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record IntakeFollowUp
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("text")]
    public required string Text { get; set; }

    [JsonPropertyName("response")]
    public string? Response { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
