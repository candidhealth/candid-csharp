using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.Guarantor.V1;

[Serializable]
public record GuarantorCreate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("phone_numbers")]
    public IEnumerable<PhoneNumber>? PhoneNumbers { get; set; }

    /// <summary>
    /// Defaults to false
    /// </summary>
    [JsonPropertyName("phone_consent")]
    public bool? PhoneConsent { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// Defaults to false
    /// </summary>
    [JsonPropertyName("email_consent")]
    public bool? EmailConsent { get; set; }

    /// <summary>
    /// Defaults to false
    /// </summary>
    [JsonPropertyName("auto_charge_consent")]
    public bool? AutoChargeConsent { get; set; }

    [JsonPropertyName("first_name")]
    public required string FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public required string LastName { get; set; }

    [JsonPropertyName("external_id")]
    public required string ExternalId { get; set; }

    [JsonPropertyName("date_of_birth")]
    public DateOnly? DateOfBirth { get; set; }

    [JsonPropertyName("address")]
    public required StreetAddressShortZip Address { get; set; }

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
