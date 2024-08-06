using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.Guarantor.V1;

public record GuarantorCreate
{
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
}
