using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.ExpectedNetworkStatus.V2;

[Serializable]
public record ExpectedNetworkStatusRequestV2 : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// For some payers, payer routing depends on whether the rendered service qualifies as a behavioral health visit
    /// (e.g. Blue Shield of California routes to Magellan for behavioral health visits).
    ///
    /// For post appointment payer routing, Candid uses a CPT code list to determine whether the appointment qualifies as a
    /// behavioral health visit
    /// (see “Inputs: Service Type” in the appendix for list of qualifying CPT codes and behavioral health routing logic).
    /// Since CPT codes are not available pre-appointment, the service type input is used to determine whether the appointment is expected
    /// to qualify as behavioral health.
    /// </summary>
    [JsonPropertyName("service_type")]
    public required ServiceType ServiceType { get; set; }

    /// <summary>
    /// Expected place of service
    /// </summary>
    [JsonPropertyName("place_of_service_code")]
    public required FacilityTypeCode PlaceOfServiceCode { get; set; }

    /// <summary>
    /// Information present on the patient's insurance card
    /// </summary>
    [JsonPropertyName("subscriber_information")]
    public required ExpectedNetworkStatusSubscriberInformation SubscriberInformation { get; set; }

    [JsonPropertyName("patient_address")]
    public required StreetAddressShortZip PatientAddress { get; set; }

    [JsonPropertyName("billing_provider_id")]
    public required string BillingProviderId { get; set; }

    /// <summary>
    /// The id of the service facility where the appointment will be rendered
    /// </summary>
    [JsonPropertyName("organization_service_facility_id")]
    public required string OrganizationServiceFacilityId { get; set; }

    /// <summary>
    /// Expected date of service
    /// </summary>
    [JsonPropertyName("date_of_service")]
    public required DateOnly DateOfService { get; set; }

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
