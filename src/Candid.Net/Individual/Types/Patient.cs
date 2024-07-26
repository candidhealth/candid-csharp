using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net;

public record Patient
{
    [JsonPropertyName("individual_id")]
    public required string IndividualId { get; init; }

    [JsonPropertyName("phone_numbers")]
    public IEnumerable<PhoneNumber> PhoneNumbers { get; init; } = new List<PhoneNumber>();

    [JsonPropertyName("phone_consent")]
    public required bool PhoneConsent { get; init; }

    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonPropertyName("email_consent")]
    public required bool EmailConsent { get; init; }

    /// <summary>
    /// The ID used to identify this individual in your system. For example, your internal patient ID or an EHR patient ID.
    /// </summary>
    [JsonPropertyName("external_id")]
    public required string ExternalId { get; init; }

    /// <summary>
    /// Box 3 on the CMS-1500 claim form. The date format should be in ISO 8601 date; formatted YYYY-MM-DD (i.e. 2012-02-01)
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public required DateOnly DateOfBirth { get; init; }

    /// <summary>
    /// Box 5 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("address")]
    public required StreetAddressShortZip Address { get; init; }

    [JsonPropertyName("first_name")]
    public required string FirstName { get; init; }

    [JsonPropertyName("last_name")]
    public required string LastName { get; init; }

    [JsonPropertyName("gender")]
    public required Gender Gender { get; init; }
}
