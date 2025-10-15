using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;
using Candid.Net.InsuranceCards.V2;

namespace Candid.Net.Individual;

[Serializable]
public record Subscriber : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
