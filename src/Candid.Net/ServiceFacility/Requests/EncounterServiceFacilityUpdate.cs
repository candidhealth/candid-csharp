using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record EncounterServiceFacilityUpdate
{
    [JsonPropertyName("organization_name")]
    public string? OrganizationName { get; set; }

    /// <summary>
    /// An NPI specific to the service facility if applicable, i.e. if it has one and is not under the billing provider's NPI.
    /// Box 32 section (a) of the CMS-1500 claim form.
    ///
    /// </summary>
    [JsonPropertyName("npi")]
    public string? Npi { get; set; }

    /// <summary>
    /// zip_plus_four_code is required for service facility address. When the zip_plus_four_code is not available use "9998" as per CMS documentation.
    ///
    /// </summary>
    [JsonPropertyName("address")]
    public StreetAddressLongZip? Address { get; set; }
}
