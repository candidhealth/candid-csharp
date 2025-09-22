using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Identifiers;

public record IdentifierBase
{
    [JsonPropertyName("period")]
    public DateRangeOptionalEnd? Period { get; set; }

    [JsonPropertyName("identifier_code")]
    public required IdentifierCode IdentifierCode { get; set; }

    [JsonPropertyName("identifier_value")]
    public required object IdentifierValue { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
