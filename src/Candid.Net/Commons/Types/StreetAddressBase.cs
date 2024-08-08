using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record StreetAddressBase
{
    [JsonPropertyName("address1")]
    public required string Address1 { get; set; }

    [JsonPropertyName("address2")]
    public string? Address2 { get; set; }

    [JsonPropertyName("city")]
    public required string City { get; set; }

    [JsonPropertyName("state")]
    public required State State { get; set; }

    /// <summary>
    /// 5-digit zip code
    /// </summary>
    [JsonPropertyName("zip_code")]
    public required string ZipCode { get; set; }
}
