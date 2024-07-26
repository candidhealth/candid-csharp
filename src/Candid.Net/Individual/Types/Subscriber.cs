using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.InsuranceCards.V2;

#nullable enable

namespace Candid.Net;

public record Subscriber
{
    [JsonPropertyName("individual_id")]
    public required string IndividualId { get; init; }

    [JsonPropertyName("insurance_card")]
    public required InsuranceCard InsuranceCard { get; init; }

    [JsonPropertyName("patient_relationship_to_subscriber_code")]
    public required PatientRelationshipToInsuredCodeAll PatientRelationshipToSubscriberCode { get; init; }

    [JsonPropertyName("date_of_birth")]
    public DateOnly? DateOfBirth { get; init; }

    [JsonPropertyName("address")]
    public StreetAddressShortZip? Address { get; init; }

    [JsonPropertyName("first_name")]
    public required string FirstName { get; init; }

    [JsonPropertyName("last_name")]
    public required string LastName { get; init; }

    [JsonPropertyName("gender")]
    public required Gender Gender { get; init; }
}
