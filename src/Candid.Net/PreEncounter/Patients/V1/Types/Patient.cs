using System.Text.Json.Serialization;

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
}
