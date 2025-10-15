using System.Text.Json.Serialization;
using Candid.Net.Claims;
using Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[Serializable]
public record GetAllEncountersRequest
{
    /// <summary>
    /// Maximum number of entities per page, defaults to 100.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    /// <summary>
    /// Indicates the current status of an insurance claim within the billing process.
    /// </summary>
    [JsonIgnore]
    public ClaimStatus? ClaimStatus { get; set; }

    /// <summary>
    /// Defaults to created_at:desc.
    /// </summary>
    [JsonIgnore]
    public EncounterSortOptions? Sort { get; set; }

    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-25.
    /// </summary>
    [JsonIgnore]
    public DateOnly? DateOfServiceMin { get; set; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-25.
    /// </summary>
    [JsonIgnore]
    public DateOnly? DateOfServiceMax { get; set; }

    /// <summary>
    /// Comma delimited string.
    /// </summary>
    [JsonIgnore]
    public string? PrimaryPayerNames { get; set; }

    /// <summary>
    /// Filter by any of the following fields: encounter_id, claim_id, patient external_id,
    /// patient date of birth, patient first name, patient last name,
    /// or encounter external id.
    /// </summary>
    [JsonIgnore]
    public string? SearchTerm { get; set; }

    /// <summary>
    /// Filter to an exact match on encounter external_id, if one exists.
    /// </summary>
    [JsonIgnore]
    public string? ExternalId { get; set; }

    /// <summary>
    /// ISO 8601 timestamp; ideally in UTC (although not required): 2019-08-24T14:15:22Z.
    /// </summary>
    [JsonIgnore]
    public DateTime? DiagnosesUpdatedSince { get; set; }

    /// <summary>
    /// Filter by name of tags on encounters.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> TagIds { get; set; } = new List<string>();

    [JsonIgnore]
    public string? WorkQueueId { get; set; }

    /// <summary>
    /// Defines if the Encounter is to be billed by Candid to the responsible_party. Examples for when this should be set to NOT_BILLABLE include if the Encounter has not occurred yet or if there is no intention of ever billing the responsible_party.
    /// </summary>
    [JsonIgnore]
    public BillableStatusType? BillableStatus { get; set; }

    /// <summary>
    /// Defines the party to be billed with the initial balance owed on the claim. Use SELF_PAY if you intend to bill self pay/cash pay.
    /// </summary>
    [JsonIgnore]
    public ResponsiblePartyType? ResponsibleParty { get; set; }

    /// <summary>
    /// The party who is responsible for taking the next action on an Encounter, as defined by ownership of open Tasks.
    /// </summary>
    [JsonIgnore]
    public EncounterOwnerOfNextActionType? OwnerOfNextAction { get; set; }

    /// <summary>
    /// The patient ID from the external EMR platform for the patient
    /// </summary>
    [JsonIgnore]
    public string? PatientExternalId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
