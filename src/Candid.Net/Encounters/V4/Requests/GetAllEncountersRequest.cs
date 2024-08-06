using Candid.Net;
using Candid.Net.Encounters.V4;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record GetAllEncountersRequest
{
    /// <summary>
    /// Maximum number of entities per page, defaults to 100.
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// Indicates the current status of an insurance claim within the billing process.
    /// </summary>
    public ClaimStatus? ClaimStatus { get; set; }

    /// <summary>
    /// Defaults to created_at:desc.
    /// </summary>
    public EncounterSortOptions? Sort { get; set; }

    public string? PageToken { get; set; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-25.
    /// </summary>
    public DateOnly? DateOfServiceMin { get; set; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-25.
    /// </summary>
    public DateOnly? DateOfServiceMax { get; set; }

    /// <summary>
    /// Comma delimited string.
    /// </summary>
    public string? PrimaryPayerNames { get; set; }

    /// <summary>
    /// Filter by any of the following fields: encounter_id, claim_id, patient external_id,
    /// patient date of birth, patient first name, patient last name,
    /// or encounter external id.
    /// </summary>
    public string? SearchTerm { get; set; }

    /// <summary>
    /// Filter to an exact match on encounter external_id, if one exists.
    /// </summary>
    public string? ExternalId { get; set; }

    /// <summary>
    /// ISO 8601 timestamp; ideally in UTC (although not required): 2019-08-24T14:15:22Z.
    /// </summary>
    public DateTime? DiagnosesUpdatedSince { get; set; }

    /// <summary>
    /// Filter by name of tags on encounters.
    /// </summary>
    public IEnumerable<string> TagIds { get; set; } = new List<string>();

    public string? WorkQueueId { get; set; }

    /// <summary>
    /// Defines if the Encounter is to be billed by Candid to the responsible_party. Examples for when this should be set to NOT_BILLABLE include if the Encounter has not occurred yet or if there is no intention of ever billing the responsible_party.
    /// </summary>
    public BillableStatusType? BillableStatus { get; set; }

    /// <summary>
    /// Defines the party to be billed with the initial balance owed on the claim. Use SELF_PAY if you intend to bill self pay/cash pay.
    /// </summary>
    public ResponsiblePartyType? ResponsibleParty { get; set; }

    /// <summary>
    /// The party who is responsible for taking the next action on an Encounter, as defined by ownership of open Tasks.
    /// </summary>
    public EncounterOwnerOfNextActionType? OwnerOfNextAction { get; set; }

    /// <summary>
    /// The patient ID from the external EMR platform for the patient
    /// </summary>
    public string? PatientExternalId { get; set; }
}
