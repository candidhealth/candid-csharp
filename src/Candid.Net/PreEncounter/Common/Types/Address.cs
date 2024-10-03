using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter;

public record Address
{
    [JsonPropertyName("use")]
    public required AddressUse Use { get; set; }

    [JsonPropertyName("line")]
    public IEnumerable<string> Line { get; set; } = new List<string>();

    [JsonPropertyName("city")]
    public required string City { get; set; }

    [JsonPropertyName("state")]
    public required string State { get; set; }

    [JsonPropertyName("postal_code")]
    public required string PostalCode { get; set; }

    [JsonPropertyName("country")]
    public required string Country { get; set; }

    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
