using System.Text.Json.Serialization;
using Candid.Net.InsuranceCards.V2;

#nullable enable

namespace Candid.Net;

public record Subscriber
{
    [JsonPropertyName("individual_id")]
    public required string IndividualId { get; set; }

    [JsonPropertyName("insurance_card")]
    public required InsuranceCard InsuranceCard { get; set; }

    [JsonPropertyName("patient_relationship_to_subscriber_code")]
    public required PatientRelationshipToInsuredCodeAll PatientRelationshipToSubscriberCode { get; set; }

    [JsonPropertyName("date_of_birth")]
    public DateOnly? DateOfBirth { get; set; }

    [JsonPropertyName("address")]
    public StreetAddressShortZip? Address { get; set; }

    [JsonPropertyName("first_name")]
    public required string FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public required string LastName { get; set; }

    [JsonPropertyName("gender")]
    public required Gender Gender { get; set; }
}
