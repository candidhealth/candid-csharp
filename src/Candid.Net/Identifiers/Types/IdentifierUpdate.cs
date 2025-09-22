using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Identifiers;

public record IdentifierUpdate
{
    [JsonPropertyName("identifier_id")]
    public required string IdentifierId { get; set; }

    [JsonPropertyName("identifier_code")]
    public IdentifierCode? IdentifierCode { get; set; }

    [JsonPropertyName("identifier_value")]
    public object? IdentifierValue { get; set; }

    [JsonPropertyName("period")]
    public object? Period { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
