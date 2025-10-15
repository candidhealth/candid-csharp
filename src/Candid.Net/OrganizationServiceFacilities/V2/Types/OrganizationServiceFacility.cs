using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.OrganizationServiceFacilities.V2;

[Serializable]
public record OrganizationServiceFacility : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
    /// An ID for this service facility used in an external system (e.g. your EMR). Service facilities can be queried by this field.
    /// </summary>
    [JsonPropertyName("external_id")]
    public string? ExternalId { get; set; }

    /// <summary>
    /// An NPI specific to the service facility if applicable, i.e. if it has one and is not under the billing provider's NPI.
    /// Box 32 section (a) of the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("npi")]
    public string? Npi { get; set; }

    /// <summary>
    /// The Place of Service (POS) code for this service facility.
    /// </summary>
    [JsonPropertyName("place_of_service_code")]
    public FacilityTypeCode? PlaceOfServiceCode { get; set; }

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
