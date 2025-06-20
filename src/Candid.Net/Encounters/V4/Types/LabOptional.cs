using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record LabOptional
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("code_type")]
    public LabCodeType? CodeType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
