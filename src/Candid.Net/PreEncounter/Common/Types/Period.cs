using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter;

public record Period
{
    [JsonPropertyName("start")]
    public DateOnly? Start { get; set; }

    [JsonPropertyName("end")]
    public DateOnly? End { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
