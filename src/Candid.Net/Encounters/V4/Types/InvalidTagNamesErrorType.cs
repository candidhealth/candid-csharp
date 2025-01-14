using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record InvalidTagNamesErrorType
{
    [JsonPropertyName("invalid_tag_names")]
    public IEnumerable<string> InvalidTagNames { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
