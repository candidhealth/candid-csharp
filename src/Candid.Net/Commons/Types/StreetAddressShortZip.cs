using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record StreetAddressShortZip
{
    /// <summary>
    /// 4-digit zip add-on code https://en.wikipedia.org/wiki/ZIP_Code#ZIP+4
    /// </summary>
    [JsonPropertyName("zip_plus_four_code")]
    public string? ZipPlusFourCode { get; set; }
}
