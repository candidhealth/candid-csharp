using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Common;

namespace Candid.Net.PreEncounter.Patients.V1;

/// <summary>
/// A patient object with immutable server-owned properties.
/// </summary>
[Serializable]
public record Patient : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The unique UUID identifier for a Patient.  Patient ID is used in machine contexts.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The medical record number for the patient.  Human-friendly Candid generated MRNs are of the form "YYMMDDXXXX", where "YYMMDD" is the date of patient creation and "XXXX" is a zero-padded incrementing integer.
    /// </summary>
    [JsonPropertyName("mrn")]
    public required string Mrn { get; set; }

    /// <summary>
    /// The organization that owns this object.
    /// </summary>
    [JsonPropertyName("organization_id")]
    public required string OrganizationId { get; set; }

    /// <summary>
    /// True if the object is deactivated.  Deactivated objects are not returned in search results but are returned in all other endpoints including scan.
    /// </summary>
    [JsonPropertyName("deactivated")]
    public required bool Deactivated { get; set; }

    /// <summary>
    /// The version of the object. Any update to any property of an object object will create a new version.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; set; }

    [JsonPropertyName("updated_at")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// The user ID of the user who last updated the object.
    /// </summary>
    [JsonPropertyName("updating_user_id")]
    public required string UpdatingUserId { get; set; }

    [JsonPropertyName("name")]
    public required HumanName Name { get; set; }

    /// <summary>
    /// Other names for the patient.
    /// </summary>
    [JsonPropertyName("other_names")]
    public IEnumerable<HumanName> OtherNames { get; set; } = new List<HumanName>();

    /// <summary>
    /// Other identifiers for the patient.
    /// </summary>
    [JsonPropertyName("other_identifiers")]
    public IEnumerable<ExternalIdentifier>? OtherIdentifiers { get; set; }

    [JsonPropertyName("gender")]
    public global::Candid.Net.PreEncounter.Common.Gender? Gender { get; set; }

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

    /// <summary>
    /// The pronouns of the patient.
    /// </summary>
    [JsonPropertyName("pronouns")]
    public IEnumerable<string>? Pronouns { get; set; }

    [JsonPropertyName("race")]
    public Race? Race { get; set; }

    [JsonPropertyName("ethnicity")]
    public Ethnicity? Ethnicity { get; set; }

    [JsonPropertyName("disability_status")]
    public DisabilityStatus? DisabilityStatus { get; set; }

    [JsonPropertyName("marital_status")]
    public MaritalStatus? MaritalStatus { get; set; }

    /// <summary>
    /// Time of death for the patient.  Leave unset if the patient is not deceased.
    /// </summary>
    [JsonPropertyName("deceased")]
    public DateTime? Deceased { get; set; }

    /// <summary>
    /// The number of siblings the patient was born with.  Leave unset if the patient was not part of a multiple birth.
    /// </summary>
    [JsonPropertyName("multiple_birth")]
    public int? MultipleBirth { get; set; }

    /// <summary>
    /// The primary address for the patient.
    /// </summary>
    [JsonPropertyName("primary_address")]
    public required global::Candid.Net.PreEncounter.Common.Address PrimaryAddress { get; set; }

    /// <summary>
    /// Other addresses for the patient.
    /// </summary>
    [JsonPropertyName("other_addresses")]
    public IEnumerable<global::Candid.Net.PreEncounter.Common.Address> OtherAddresses { get; set; } =
        new List<global::Candid.Net.PreEncounter.Common.Address>();

    /// <summary>
    /// The primary phone number for the patient.
    /// </summary>
    [JsonPropertyName("primary_telecom")]
    public ContactPoint? PrimaryTelecom { get; set; }

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
    /// Information about the upstream system that owns this patient data.  Leave unset if Candid owns patient data.
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
    /// Associated service facilities for this patient.
    /// </summary>
    [JsonPropertyName("service_facilities")]
    public IEnumerable<PatientServiceFacility>? ServiceFacilities { get; set; }

    /// <summary>
    /// If this value is defined, the customer will not be invoiced.
    /// </summary>
    [JsonPropertyName("do_not_invoice_reason")]
    public DoNotInvoiceReason? DoNotInvoiceReason { get; set; }

    [JsonPropertyName("note_ids")]
    public IEnumerable<string>? NoteIds { get; set; }

    [JsonPropertyName("tag_ids")]
    public IEnumerable<string>? TagIds { get; set; }

    /// <summary>
    /// Information about the patient source, if applicable.
    /// </summary>
    [JsonPropertyName("origination_detail")]
    public OriginationDetail? OriginationDetail { get; set; }

    /// <summary>
    /// Metadata for the patient used for patient inference from encounters.
    /// </summary>
    [JsonPropertyName("inferred_patient_metadata")]
    public InferredPatientMetadata? InferredPatientMetadata { get; set; }

    /// <summary>
    /// ORCON (Originator Controlled) - When set to true, the Candid system will hide this patient from downstream integrations. Defaults to false.
    /// </summary>
    [JsonPropertyName("orcon")]
    public bool? Orcon { get; set; }

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
