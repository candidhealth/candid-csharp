using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net;

public record StreetAddressShortZip
{
    /// <summary>
    /// 4-digit zip add-on code https://en.wikipedia.org/wiki/ZIP_Code#ZIP+4
    /// </summary>
    [JsonPropertyName("zip_plus_four_code")]
    public string? ZipPlusFourCode { get; init; }

    [JsonPropertyName("address1")]
    public required string Address1 { get; init; }

    [JsonPropertyName("address2")]
    public string? Address2 { get; init; }

    [JsonPropertyName("city")]
    public required string City { get; init; }

    [JsonPropertyName("state")]
    public required State State { get; init; }

    /// <summary>
    /// 5-digit zip code
    /// </summary>
    [JsonPropertyName("zip_code")]
    public required string ZipCode { get; init; }
}
