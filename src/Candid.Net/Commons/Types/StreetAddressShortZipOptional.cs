using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Commons;

public record StreetAddressShortZipOptional
{
    /// <summary>
    /// 4-digit zip add-on code https://en.wikipedia.org/wiki/ZIP_Code#ZIP+4
    /// </summary>
    [JsonPropertyName("zip_plus_four_code")]
    public string? ZipPlusFourCode { get; set; }

    [JsonPropertyName("address1")]
    public string? Address1 { get; set; }

    [JsonPropertyName("address2")]
    public string? Address2 { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("state")]
    public State? State { get; set; }

    /// <summary>
    /// 5-digit zip code
    /// </summary>
    [JsonPropertyName("zip_code")]
    public string? ZipCode { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
