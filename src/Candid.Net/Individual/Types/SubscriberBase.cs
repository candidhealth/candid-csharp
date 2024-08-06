using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net;

public record SubscriberBase
{
    [JsonPropertyName("patient_relationship_to_subscriber_code")]
    public required PatientRelationshipToInsuredCodeAll PatientRelationshipToSubscriberCode { get; set; }

    [JsonPropertyName("date_of_birth")]
    public DateOnly? DateOfBirth { get; set; }

    [JsonPropertyName("address")]
    public StreetAddressShortZip? Address { get; set; }
}
