using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record SchemaInstanceValidationFailure
{
    [JsonPropertyName("errors")]
    public IEnumerable<object> Errors { get; set; } = new List<object>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
