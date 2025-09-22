using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.OrganizationServiceFacilities.V2;

public record OrganizationServiceFacility
{
    [JsonPropertyName("organization_service_facility_id")]
    public required string OrganizationServiceFacilityId { get; set; }

    /// <summary>
    /// The name of the service facility.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// A list of alternate names for the service facility.
    /// </summary>
    [JsonPropertyName("aliases")]
    public IEnumerable<string> Aliases { get; set; } = new List<string>();

    /// <summary>
    /// A description of the service facility.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// An NPI specific to the service facility if applicable, i.e. if it has one and is not under the billing provider's NPI.
    /// Box 32 section (a) of the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("npi")]
    public string? Npi { get; set; }

    /// <summary>
    /// The status of the service facility.
    /// </summary>
    [JsonPropertyName("status")]
    public ServiceFacilityStatus? Status { get; set; }

    /// <summary>
    /// The operational status of the service facility.
    /// </summary>
    [JsonPropertyName("operational_status")]
    public ServiceFacilityOperationalStatus? OperationalStatus { get; set; }

    /// <summary>
    /// The mode of the service facility.
    /// </summary>
    [JsonPropertyName("mode")]
    public ServiceFacilityMode? Mode { get; set; }

    /// <summary>
    /// The type of the service facility.
    /// </summary>
    [JsonPropertyName("type")]
    public ServiceFacilityType? Type { get; set; }

    /// <summary>
    /// The physical type of the service facility.
    /// </summary>
    [JsonPropertyName("physical_type")]
    public ServiceFacilityPhysicalType? PhysicalType { get; set; }

    /// <summary>
    /// A list of contact methods for the service facility.
    /// </summary>
    [JsonPropertyName("telecoms")]
    public IEnumerable<string> Telecoms { get; set; } = new List<string>();

    /// <summary>
    /// The address of the service facility.
    /// </summary>
    [JsonPropertyName("address")]
    public required StreetAddressLongZip Address { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
