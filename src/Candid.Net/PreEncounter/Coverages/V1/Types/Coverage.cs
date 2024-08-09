using System.Text.Json.Serialization;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record Coverage
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The organization that owns this coverage.
    /// </summary>
    [JsonPropertyName("organization_id")]
    public required string OrganizationId { get; set; }

    /// <summary>
    /// True if the coverage is deactivated. Deactivated coverages are not returned in search results but are returned in all other endpoints including scan.
    /// </summary>
    [JsonPropertyName("deactivated")]
    public required bool Deactivated { get; set; }

    /// <summary>
    /// The version of the coverage. Any update to any property of a coverage object will create a new version.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; set; }

    [JsonPropertyName("updated_at")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// The user ID of the user who last updated the coverage.
    /// </summary>
    [JsonPropertyName("updating_user_id")]
    public required string UpdatingUserId { get; set; }

    /// <summary>
    /// The status indiciating if the coverage is active or not.
    /// </summary>
    [JsonPropertyName("status")]
    public required CoverageStatus Status { get; set; }

    /// <summary>
    /// The party who has signed-up for or 'owns' the contractual relationship to the policy or to whom the benefit of the policy for services rendered to them or their family is due.
    /// </summary>
    [JsonPropertyName("subscriber")]
    public required Subscriber Subscriber { get; set; }

    /// <summary>
    /// The relationship of beneficiary (patient) to the subscriber. https://hl7.org/fhir/valueset-relationship.html
    /// </summary>
    [JsonPropertyName("relationship")]
    public required Relationship Relationship { get; set; }

    /// <summary>
    /// The patient who benefits from the insurance coverage
    /// </summary>
    [JsonPropertyName("patient")]
    public required string Patient { get; set; }

    [JsonPropertyName("insurance_plan")]
    public required InsurancePlan InsurancePlan { get; set; }

    /// <summary>
    /// A boolean indicating if the coverage has been verified by a user.
    /// </summary>
    [JsonPropertyName("verified")]
    public required bool Verified { get; set; }
}
