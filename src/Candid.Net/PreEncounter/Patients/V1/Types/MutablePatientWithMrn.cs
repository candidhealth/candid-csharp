using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public record MutablePatientWithMrn
{
    /// <summary>
    /// The medical record number for the patient.
    /// </summary>
    [JsonPropertyName("mrn")]
    public required string Mrn { get; set; }

    [JsonPropertyName("name")]
    public required HumanName Name { get; set; }

    /// <summary>
    /// Other names for the patient.
    /// </summary>
    [JsonPropertyName("other_names")]
    public IEnumerable<HumanName> OtherNames { get; set; } = new List<HumanName>();

    [JsonPropertyName("gender")]
    public Gender? Gender { get; set; }

    [JsonPropertyName("birth_date")]
    public required DateOnly BirthDate { get; set; }

    [JsonPropertyName("social_security_number")]
    public string? SocialSecurityNumber { get; set; }

    /// <summary>
    /// The biological sex of the patient. This corresponds to the HL7 AdministrativeGender https://www.hl7.org/fhir/valueset-administrative-gender.html
    /// </summary>
    [JsonPropertyName("biological_sex")]
    public required Sex BiologicalSex { get; set; }

    /// <summary>
    /// The sexual orientation of the patient.
    /// </summary>
    [JsonPropertyName("sexual_orientation")]
    public SexualOrientation? SexualOrientation { get; set; }

    [JsonPropertyName("race")]
    public Race? Race { get; set; }

    [JsonPropertyName("ethnicity")]
    public Ethnicity? Ethnicity { get; set; }

    [JsonPropertyName("disability_status")]
    public DisabilityStatus? DisabilityStatus { get; set; }

    [JsonPropertyName("marital_status")]
    public MaritalStatus? MaritalStatus { get; set; }

    /// <summary>
    /// Time of death for the patient. Leave unset if the patient is not deceased.
    /// </summary>
    [JsonPropertyName("deceased")]
    public DateTime? Deceased { get; set; }

    /// <summary>
    /// The number of siblings the patient was born with. Leave unset if the patient was not part of a multiple birth.
    /// </summary>
    [JsonPropertyName("multiple_birth")]
    public int? MultipleBirth { get; set; }

    /// <summary>
    /// The primary address for the patient.
    /// </summary>
    [JsonPropertyName("primary_address")]
    public required Address PrimaryAddress { get; set; }

    /// <summary>
    /// Other addresses for the patient.
    /// </summary>
    [JsonPropertyName("other_addresses")]
    public IEnumerable<Address> OtherAddresses { get; set; } = new List<Address>();

    /// <summary>
    /// The primary phone number for the patient.
    /// </summary>
    [JsonPropertyName("primary_telecom")]
    public required ContactPoint PrimaryTelecom { get; set; }

    /// <summary>
    /// Other phone numbers for the patient.
    /// </summary>
    [JsonPropertyName("other_telecoms")]
    public IEnumerable<ContactPoint> OtherTelecoms { get; set; } = new List<ContactPoint>();

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("electronic_communication_opt_in")]
    public bool? ElectronicCommunicationOptIn { get; set; }

    [JsonPropertyName("photo")]
    public string? Photo { get; set; }

    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>
    /// Information about the upstream system that owns this patient data. Leave unset if Candid owns patient data.
    /// </summary>
    [JsonPropertyName("external_provenance")]
    public ExternalProvenance? ExternalProvenance { get; set; }

    /// <summary>
    /// Contacts for the patient.
    /// </summary>
    [JsonPropertyName("contacts")]
    public IEnumerable<Contact> Contacts { get; set; } = new List<Contact>();

    [JsonPropertyName("general_practitioners")]
    public IEnumerable<ExternalProvider> GeneralPractitioners { get; set; } =
        new List<ExternalProvider>();

    [JsonPropertyName("filing_order")]
    public required FilingOrder FilingOrder { get; set; }

    [JsonPropertyName("non_insurance_payers")]
    public IEnumerable<string>? NonInsurancePayers { get; set; }

    [JsonPropertyName("non_insurance_payer_associations")]
    public IEnumerable<CanonicalNonInsurancePayerAssociation>? NonInsurancePayerAssociations { get; set; }

    [JsonPropertyName("guarantor")]
    public Guarantor? Guarantor { get; set; }

    [JsonPropertyName("self_pay")]
    public bool? SelfPay { get; set; }

    [JsonPropertyName("authorizations")]
    public IEnumerable<Authorization>? Authorizations { get; set; }

    [JsonPropertyName("referrals")]
    public IEnumerable<Referral>? Referrals { get; set; }

    [JsonPropertyName("primary_service_facility_id")]
    public string? PrimaryServiceFacilityId { get; set; }

    /// <summary>
    /// If this value is defined, the customer will not be invoiced.
    /// </summary>
    [JsonPropertyName("do_not_invoice_reason")]
    public DoNotInvoiceReason? DoNotInvoiceReason { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
