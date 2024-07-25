using System.Text.Json.Serialization;
using Candid.Net.PreEncounter;
using Candid.Net.PreEncounter.Patients.V1;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public record MutablePatient
{
    [JsonPropertyName("name")]
    public required HumanName Name { get; init; }

    /// <summary>
    /// Other names for the patient.
    /// </summary>
    [JsonPropertyName("other_names")]
    public IEnumerable<HumanName> OtherNames { get; init; } = new List<HumanName>();

    [JsonPropertyName("gender")]
    public required Gender Gender { get; init; }

    [JsonPropertyName("birth_date")]
    public required DateOnly BirthDate { get; init; }

    [JsonPropertyName("marital_status")]
    public MaritalStatus? MaritalStatus { get; init; }

    /// <summary>
    /// Time of death for the patient. Leave unset if the patient is not deceased.
    /// </summary>
    [JsonPropertyName("deceased")]
    public DateTime? Deceased { get; init; }

    /// <summary>
    /// The number of siblings the patient was born with. Leave unset if the patient was not part of a multiple birth.
    /// </summary>
    [JsonPropertyName("multiple_birth")]
    public int? MultipleBirth { get; init; }

    /// <summary>
    /// The primary address for the patient.
    /// </summary>
    [JsonPropertyName("primary_address")]
    public required Address PrimaryAddress { get; init; }

    /// <summary>
    /// Other addresses for the patient.
    /// </summary>
    [JsonPropertyName("other_addresses")]
    public IEnumerable<Address> OtherAddresses { get; init; } = new List<Address>();

    /// <summary>
    /// The primary phone number for the patient.
    /// </summary>
    [JsonPropertyName("primary_telecom")]
    public required ContactPoint PrimaryTelecom { get; init; }

    /// <summary>
    /// Other phone numbers for the patient.
    /// </summary>
    [JsonPropertyName("other_telecoms")]
    public IEnumerable<ContactPoint> OtherTelecoms { get; init; } = new List<ContactPoint>();

    [JsonPropertyName("photo")]
    public string? Photo { get; init; }

    [JsonPropertyName("language")]
    public string? Language { get; init; }

    /// <summary>
    /// Information about the upstream system that owns this patient data. Leave unset if Candid owns patient data.
    /// </summary>
    [JsonPropertyName("external_provenance")]
    public ExternalProvenance? ExternalProvenance { get; init; }

    /// <summary>
    /// Contacts for the patient.
    /// </summary>
    [JsonPropertyName("contacts")]
    public IEnumerable<Contact> Contacts { get; init; } = new List<Contact>();

    [JsonPropertyName("general_practitioners")]
    public IEnumerable<ExternalProvider> GeneralPractitioners { get; init; } =
        new List<ExternalProvider>();
}
