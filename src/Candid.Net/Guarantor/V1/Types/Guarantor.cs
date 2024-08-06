using System.Text.Json.Serialization;
using Candid.Net;

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
}
