using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Individual;

public record SubscriberBase
{
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
