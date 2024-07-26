using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.Guarantor.V1;

public record Guarantor
{
    [JsonPropertyName("guarantor_id")]
    public required string GuarantorId { get; init; }

    [JsonPropertyName("phone_numbers")]
    public IEnumerable<PhoneNumber> PhoneNumbers { get; init; } = new List<PhoneNumber>();

    [JsonPropertyName("phone_consent")]
    public required bool PhoneConsent { get; init; }

    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonPropertyName("email_consent")]
    public required bool EmailConsent { get; init; }

    [JsonPropertyName("first_name")]
    public required string FirstName { get; init; }

    [JsonPropertyName("last_name")]
    public required string LastName { get; init; }

    [JsonPropertyName("external_id")]
    public required string ExternalId { get; init; }

    [JsonPropertyName("date_of_birth")]
    public DateOnly? DateOfBirth { get; init; }

    [JsonPropertyName("address")]
    public StreetAddressShortZip? Address { get; init; }
}
