using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public record EntityConflictErrorMessage
{
    [JsonPropertyName("entity_name")]
    public required string EntityName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
