using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;
using Candid.Net.NonInsurancePayers.V1;

#nullable enable

namespace Candid.Net.Individual;

public record Patient
{
    [JsonPropertyName("individual_id")]
    public required string IndividualId { get; set; }

    [JsonPropertyName("phone_numbers")]
    public IEnumerable<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();

    [JsonPropertyName("phone_consent")]
    public required bool PhoneConsent { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("email_consent")]
    public required bool EmailConsent { get; set; }

    [JsonPropertyName("non_insurance_payers")]
    public IEnumerable<NonInsurancePayer> NonInsurancePayers { get; set; } =
        new List<NonInsurancePayer>();

    [JsonPropertyName("non_insurance_payers_info")]
    public IEnumerable<PatientNonInsurancePayerInfo> NonInsurancePayersInfo { get; set; } =
        new List<PatientNonInsurancePayerInfo>();

    /// <summary>
    /// The ID used to identify this individual in your system. For example, your internal patient ID or an EHR patient ID.
    /// </summary>
    [JsonPropertyName("external_id")]
    public required string ExternalId { get; set; }

    /// <summary>
    /// Box 3 on the CMS-1500 claim form or Form Locator 10 on a UB-04 claim form. The date format should be in ISO 8601 date; formatted YYYY-MM-DD (i.e. 2012-02-01)
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public required DateOnly DateOfBirth { get; set; }

    /// <summary>
    /// Box 5 on the CMS-1500 claim form or Form Locator 9 on a UB-04 claim form.
    /// </summary>
    [JsonPropertyName("address")]
    public required StreetAddressShortZip Address { get; set; }

    [JsonPropertyName("first_name")]
    public required string FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public required string LastName { get; set; }

    [JsonPropertyName("gender")]
    public required Gender Gender { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
