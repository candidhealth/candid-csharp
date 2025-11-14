using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.ServiceFacility;

[Serializable]
public record EncounterServiceFacility : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("service_facility_id")]
    public required string ServiceFacilityId { get; set; }

    [JsonPropertyName("organization_name")]
    public required string OrganizationName { get; set; }

    /// <summary>
    /// An NPI specific to the service facility if applicable, i.e. if it has one and is not under the billing provider's NPI.
    /// Box 32 section (a) of the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("npi")]
    public string? Npi { get; set; }

    /// <summary>
    /// zip_plus_four_code is required for service facility address. When the zip_plus_four_code is not available use "9998" as per CMS documentation.
    /// </summary>
    [JsonPropertyName("address")]
    public required StreetAddressLongZip Address { get; set; }

    /// <summary>
    /// An additional identifier for the service facility other than the facility's NPI. Some payers may require this field.
    /// Potential examples: state license number, provider commercial number, or location number.
    /// Box 32 section (b) of the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("secondary_identification")]
    public string? SecondaryIdentification { get; set; }

    /// <summary>
    /// The associated mammography certification number for this service facility. This is a 6 digit code assigned by the FDA.
    /// </summary>
    [JsonPropertyName("mammography_certification_number")]
    public string? MammographyCertificationNumber { get; set; }

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
