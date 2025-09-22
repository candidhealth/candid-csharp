using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;
using Candid.Net.InsuranceCards.V2;

#nullable enable

namespace Candid.Net.Individual;

public record SubscriberCreateOptional
{
    /// <summary>
    /// Please reference our [Payer Information](https://docs.joincandidhealth.com/introduction/payer-information) documentation for more details on how to populate the `insurance_card` fields.
    /// </summary>
    [JsonPropertyName("insurance_card")]
    public InsuranceCardCreateOptional? InsuranceCard { get; set; }

    [JsonPropertyName("patient_relationship_to_subscriber_code")]
    public PatientRelationshipToInsuredCodeAll? PatientRelationshipToSubscriberCode { get; set; }

    [JsonPropertyName("date_of_birth")]
    public DateOnly? DateOfBirth { get; set; }

    [JsonPropertyName("address")]
    public StreetAddressShortZipOptional? Address { get; set; }

    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("gender")]
    public Gender? Gender { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
