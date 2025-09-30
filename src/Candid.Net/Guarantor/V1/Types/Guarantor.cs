using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Guarantor.V1;

public record Guarantor
{
    [JsonPropertyName("guarantor_id")]
    public required string GuarantorId { get; set; }

    [JsonPropertyName("phone_numbers")]
    public IEnumerable<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();

    [JsonPropertyName("phone_consent")]
    public required bool PhoneConsent { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("email_consent")]
    public required bool EmailConsent { get; set; }

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
