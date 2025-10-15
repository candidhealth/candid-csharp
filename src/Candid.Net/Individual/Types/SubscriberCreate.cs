using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;
using Candid.Net.InsuranceCards.V2;

namespace Candid.Net.Individual;

[Serializable]
public record SubscriberCreate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Please reference our [Payer Information](https://docs.joincandidhealth.com/introduction/payer-information) documentation for more details on how to populate the `insurance_card` fields.
    /// </summary>
    [JsonPropertyName("insurance_card")]
    public required InsuranceCardCreate InsuranceCard { get; set; }

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
