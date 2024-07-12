using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.OrganizationServiceFacilities.V2;

#nullable enable

namespace Candid.Net.OrganizationServiceFacilities.V2;

public record OrganizationServiceFacility
{
    [JsonPropertyName("organization_service_facility_id")]
    public required Guid OrganizationServiceFacilityId { get; init; }

    /// <summary>
    /// The name of the service facility.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// A list of alternate names for the service facility.
    /// </summary>
    [JsonPropertyName("aliases")]
    public IEnumerable<string> Aliases { get; init; } = new List<string>();

    /// <summary>
    /// A description of the service facility.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// An NPI specific to the service facility if applicable, i.e. if it has one and is not under the billing provider's NPI.
    /// Box 32 section (a) of the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("npi")]
    public string? Npi { get; init; }

    /// <summary>
    /// The status of the service facility.
    /// </summary>
    [JsonPropertyName("status")]
    public ServiceFacilityStatus? Status { get; init; }

    /// <summary>
    /// The operational status of the service facility.
    /// </summary>
    [JsonPropertyName("operational_status")]
    public ServiceFacilityOperationalStatus? OperationalStatus { get; init; }

    /// <summary>
    /// The mode of the service facility.
    /// </summary>
    [JsonPropertyName("mode")]
    public ServiceFacilityMode? Mode { get; init; }

    /// <summary>
    /// The type of the service facility.
    /// </summary>
    [JsonPropertyName("type")]
    public ServiceFacilityType? Type { get; init; }

    /// <summary>
    /// The physical type of the service facility.
    /// </summary>
    [JsonPropertyName("physical_type")]
    public ServiceFacilityPhysicalType? PhysicalType { get; init; }

    /// <summary>
    /// A list of contact methods for the service facility.
    /// </summary>
    [JsonPropertyName("telecoms")]
    public IEnumerable<string> Telecoms { get; init; } = new List<string>();

    /// <summary>
    /// The address of the service facility.
    /// </summary>
    [JsonPropertyName("address")]
    public required StreetAddressLongZip Address { get; init; }
}
