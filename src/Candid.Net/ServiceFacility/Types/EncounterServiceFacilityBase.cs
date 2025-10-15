using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.ServiceFacility;

/// <summary>
/// Encounter Service facility is typically the location a medical service was rendered, such as a provider office or hospital.
/// For telehealth, service facility can represent the provider's location when the service was delivered (e.g., home),
/// or the location where an in-person visit would have taken place, whichever is easier to identify.
/// If the provider is in-network, service facility may be defined in payer contracts.
/// Box 32 on the CMS-1500 claim form.
/// Note that for an in-network claim to be successfully adjudicated, the service facility address listed on claims
/// must match what was provided to the payer during the credentialing process.
/// </summary>
[Serializable]
public record EncounterServiceFacilityBase : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
