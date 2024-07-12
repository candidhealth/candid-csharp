using System.Text.Json.Serialization;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter;

public record Patient
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The organization that owns this patient.
    /// </summary>
    [JsonPropertyName("organization_id")]
    public required string OrganizationId { get; init; }

    /// <summary>
    /// True if the patient is deactivated. Deactivated patients are not returned in search results but are returned in all other endpoints including scan.
    /// </summary>
    [JsonPropertyName("deactivated")]
    public required bool Deactivated { get; init; }

    /// <summary>
    /// The version of the patient. Any update to any property of a patient object will create a new version.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; init; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; init; }

    /// <summary>
    /// The user ID of the user who last updated the patient.
    /// </summary>
    [JsonPropertyName("updatingUserId")]
    public required string UpdatingUserId { get; init; }

    [JsonPropertyName("name")]
    public required HumanName Name { get; init; }

    /// <summary>
    /// Other names for the patient.
    /// </summary>
    [JsonPropertyName("otherNames")]
    public IEnumerable<HumanName> OtherNames { get; init; } = new List<HumanName>();

    [JsonPropertyName("gender")]
    public required Gender Gender { get; init; }

    [JsonPropertyName("birthDate")]
    public required DateOnly BirthDate { get; init; }

    [JsonPropertyName("maritalStatus")]
    public MaritalStatus? MaritalStatus { get; init; }

    /// <summary>
    /// Time of death for the patient. Leave unset if the patient is not deceased.
    /// </summary>
    [JsonPropertyName("deceased")]
    public DateTime? Deceased { get; init; }

    /// <summary>
    /// The number of siblings the patient was born with. Leave unset if the patient was not part of a multiple birth.
    /// </summary>
    [JsonPropertyName("multipleBirth")]
    public int? MultipleBirth { get; init; }

    /// <summary>
    /// The primary address for the patient.
    /// </summary>
    [JsonPropertyName("primaryAddress")]
    public required Address PrimaryAddress { get; init; }

    /// <summary>
    /// Other addresses for the patient.
    /// </summary>
    [JsonPropertyName("otherAddresses")]
    public IEnumerable<Address> OtherAddresses { get; init; } = new List<Address>();

    /// <summary>
    /// The primary phone number for the patient.
    /// </summary>
    [JsonPropertyName("primaryTelecom")]
    public required ContactPoint PrimaryTelecom { get; init; }

    /// <summary>
    /// Other phone numbers for the patient.
    /// </summary>
    [JsonPropertyName("otherTelecoms")]
    public IEnumerable<ContactPoint> OtherTelecoms { get; init; } = new List<ContactPoint>();

    [JsonPropertyName("photo")]
    public string? Photo { get; init; }

    [JsonPropertyName("language")]
    public string? Language { get; init; }

    /// <summary>
    /// Information about the upstream system that owns this patient data. Leave unset if Candid owns patient data.
    /// </summary>
    [JsonPropertyName("externalProvenance")]
    public ExternalProvenance? ExternalProvenance { get; init; }

    /// <summary>
    /// Contacts for the patient.
    /// </summary>
    [JsonPropertyName("contacts")]
    public IEnumerable<Contact> Contacts { get; init; } = new List<Contact>();

    [JsonPropertyName("generalPractitioners")]
    public IEnumerable<ExternalProvider> GeneralPractitioners { get; init; } =
        new List<ExternalProvider>();
}
