using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Individual;

public record PatientUpdate
{
    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("gender")]
    public Gender? Gender { get; set; }

    /// <summary>
    /// The ID used to identify this individual in your system. For example, your internal patient ID or an EHR patient ID.
    /// </summary>
    [JsonPropertyName("external_id")]
    public string? ExternalId { get; set; }

    /// <summary>
    /// Box 3 on the CMS-1500 claim form or Form Locator 10 on a UB-04 claim form. The date format should be in ISO 8601 date; formatted YYYY-MM-DD (i.e. 2012-02-01)
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public DateOnly? DateOfBirth { get; set; }

    /// <summary>
    /// Box 5 on the CMS-1500 claim form or Form Locator 9 on a UB-04 claim form.
    /// </summary>
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

    /// <summary>
    /// On update, we will replace the existing list of non-insurance payers with the new list if populated.
    /// </summary>
    [JsonPropertyName("non_insurance_payers")]
    public IEnumerable<string>? NonInsurancePayers { get; set; }

    /// <summary>
    /// On update, we will replace the existing list of non-insurance payers with the new list if populated.
    /// </summary>
    [JsonPropertyName("non_insurance_payers_info")]
    public IEnumerable<PatientNonInsurancePayerInfoCreate>? NonInsurancePayersInfo { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
