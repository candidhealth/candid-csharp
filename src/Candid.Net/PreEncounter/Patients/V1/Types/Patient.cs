using System.Text.Json.Serialization;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public record Patient
{
    /// <summary>
    /// The unique UUID identifier for a Patient. Patient ID is used in machine contexts.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The medical record number for the patient. Human-friendly Candid generated MRNs are of the form JCH + 8 alphanumeric characters. MRNs are not case-sensitive.
    /// </summary>
    [JsonPropertyName("mrn")]
    public required string Mrn { get; set; }

    /// <summary>
    /// The organization that owns this patient.
    /// </summary>
    [JsonPropertyName("organization_id")]
    public required string OrganizationId { get; set; }

    /// <summary>
    /// True if the patient is deactivated. Deactivated patients are not returned in search results but are returned in all other endpoints including scan.
    /// </summary>
    [JsonPropertyName("deactivated")]
    public required bool Deactivated { get; set; }

    /// <summary>
    /// The version of the patient. Any update to any property of a patient object will create a new version.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; set; }

    [JsonPropertyName("updated_at")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// The user ID of the user who last updated the patient.
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
}
