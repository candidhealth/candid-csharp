using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation.V1;

public record Rd8Date
{
    [JsonPropertyName("start")]
    public required DateTime Start { get; set; }

    [JsonPropertyName("end")]
    public required DateTime End { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
