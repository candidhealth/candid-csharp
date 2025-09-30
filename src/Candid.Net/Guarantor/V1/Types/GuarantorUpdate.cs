using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Guarantor.V1;

public record GuarantorUpdate
{
    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    /// <summary>
    /// A unique identifier for the guarantor assigned by an external system.
    /// </summary>
    [JsonPropertyName("external_id")]
    public string? ExternalId { get; set; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-25.
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public DateOnly? DateOfBirth { get; set; }

    [JsonPropertyName("address")]
    public StreetAddressShortZip? Address { get; set; }

    [JsonPropertyName("phone_numbers")]
    public IEnumerable<PhoneNumber>? PhoneNumbers { get; set; }

    [JsonPropertyName("phone_consent")]
    public bool? PhoneConsent { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("email_consent")]
    public bool? EmailConsent { get; set; }

    [JsonPropertyName("auto_charge_consent")]
    public bool? AutoChargeConsent { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
