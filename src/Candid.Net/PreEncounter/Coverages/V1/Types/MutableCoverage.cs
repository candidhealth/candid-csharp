using System.Text.Json.Serialization;
using Candid.Net.PreEncounter;
using Candid.Net.PreEncounter.Coverages.V1;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record MutableCoverage
{
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
