using System.Text.Json.Serialization;
using Candid.Net.Claims;
using Candid.Net.Core;
using Candid.Net.Encounters.V4;

namespace Candid.Net.ChargeCapture.V1;

[Serializable]
public record GetAllChargeCapturesRequest
{
    /// <summary>
    /// Maximum number of entities per page, defaults to 100.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    /// <summary>
    /// Defaults to created_at
    /// </summary>
    [JsonIgnore]
    public ChargeCaptureSortField? Sort { get; set; }

    /// <summary>
    /// Sort direction. Defaults to descending order if not provided.
    /// </summary>
    [JsonIgnore]
    public Candid.Net.Commons.SortDirection? SortDirection { get; set; }

    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <summary>
    /// The patient ID from the external EMR platform for the patient
    /// </summary>
    [JsonIgnore]
    public string? PatientExternalId { get; set; }

    /// <summary>
    /// the status of the charge captures
    /// </summary>
    [JsonIgnore]
    public ChargeCaptureStatus? Status { get; set; }

    /// <summary>
    /// A client-specified unique ID to associate with this encounter;
    /// for example, your internal encounter ID or a Dr. Chrono encounter ID.
    /// This field should not contain PHI.
    /// </summary>
    [JsonIgnore]
    public string? ChargeExternalId { get; set; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-24.
    /// This date must be the local date in the timezone where the service occurred.
    /// </summary>
    [JsonIgnore]
    public DateOnly? DateOfServiceMin { get; set; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-24.
    /// This date must be the local date in the timezone where the service occurred.
    /// </summary>
    [JsonIgnore]
    public DateOnly? DateOfServiceMax { get; set; }

    /// <summary>
    /// A list of claim IDs to filter by. This will return all charge captures that have a resulting claim with one of the IDs in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ClaimIds { get; set; } = new List<string>();

    /// <summary>
    /// A list of Claim Creation IDs to filter by.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ClaimCreationIds { get; set; } = new List<string>();

    /// <summary>
    /// A list of billing provider NPIs to filter by. This will return all charge captures with one of the NPIs in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> BillingProviderNpis { get; set; } = new List<string>();

    /// <summary>
    /// A string to filter by. This will return all charge captures with this service facility name.
    /// </summary>
    [JsonIgnore]
    public string? ServiceFacilityName { get; set; }

    /// <summary>
    /// A list of primary payer IDs to filter by. This will return all charge captures with one of the primary payer IDs in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> PrimaryPayerIds { get; set; } = new List<string>();

    /// <summary>
    /// A list of rendering provider NPIs to filter by. This will return all charge captures with one of the NPIs in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> RenderingProviderNpis { get; set; } = new List<string>();

    /// <summary>
    /// A list of rendering provider names to filter by. This will return all charge captures with one of the names in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> RenderingProviderNames { get; set; } = new List<string>();

    /// <summary>
    /// A list of supervising provider NPIs to filter by. This will return all charge captures with one of the NPIs in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> SupervisingProviderNpis { get; set; } = new List<string>();

    /// <summary>
    /// A list of supervising provider names to filter by. This will return all charge captures with one of the names in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> SupervisingProviderNames { get; set; } = new List<string>();

    /// <summary>
    /// A list of claim creation categories to filter by. This will return all charge capture claim_creations which include one or more charges with one of the names in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ClaimCreationCategory { get; set; } = new List<string>();

    /// <summary>
    /// A list of tags to filter by. This will return all charge captures with one of the tags.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Tags { get; set; } = new List<string>();

    /// <summary>
    /// A list of primary payer names to filter by. This will return all charge captures with one of the names.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> PrimaryPayerNames { get; set; } = new List<string>();

    /// <summary>
    /// A list of patient names to filter by. This will return all charge captures with one of the names.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> PatientNames { get; set; } = new List<string>();

    /// <summary>
    /// Whether to exclude charge captures which are part of a claim creation.
    /// </summary>
    [JsonIgnore]
    public bool? ExcludeChargesLinkedToClaims { get; set; }

    /// <summary>
    /// The patient ID from the external EMR platform for the patient
    /// </summary>
    [JsonIgnore]
    public string? PatientExternalIdRankedSort { get; set; }

    /// <summary>
    /// The charge capture status to show first
    /// </summary>
    [JsonIgnore]
    public ChargeCaptureStatus? StatusRankedSort { get; set; }

    /// <summary>
    /// A client-specified unique ID to associate with this encounter;
    /// for example, your internal encounter ID or a Dr. Chrono encounter ID.
    /// This field should not contain PHI.
    /// </summary>
    [JsonIgnore]
    public string? ChargeExternalIdRankedSort { get; set; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-24.
    /// This date must be the local date in the timezone where the service occurred.
    /// </summary>
    [JsonIgnore]
    public DateOnly? DateOfServiceMinRankedSort { get; set; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-24.
    /// This date must be the local date in the timezone where the service occurred.
    /// </summary>
    [JsonIgnore]
    public DateOnly? DateOfServiceMaxRankedSort { get; set; }

    /// <summary>
    /// Filter by any of the following fields: charge_id, claim_id, patient external_id,
    /// patient date of birth, patient first name, patient last name,
    /// or charge external id.
    /// </summary>
    [JsonIgnore]
    public string? SearchTerm { get; set; }

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
    /// A list of claim IDs to show first. This will return all charge captures that have a resulting claim with one of the IDs in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ClaimIdsRankedSort { get; set; } = new List<string>();

    /// <summary>
    /// A list of Claim Creation IDs to show first.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ClaimCreationIdsRankedSort { get; set; } = new List<string>();

    /// <summary>
    /// A list of billing provider NPIs to show first. This will return all charge captures with one of the NPIs in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> BillingProviderNpisRankedSort { get; set; } = new List<string>();

    /// <summary>
    /// A string to show first. This will return all charge captures with this service facility name.
    /// </summary>
    [JsonIgnore]
    public string? ServiceFacilityNameRankedSort { get; set; }

    /// <summary>
    /// A list of primary payer IDs to show first. This will return all charge captures with one of the primary payer IDs in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> PrimaryPayerIdsRankedSort { get; set; } = new List<string>();

    /// <summary>
    /// A list of rendering provider NPIs to show first. This will return all charge captures with one of the NPIs in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> RenderingProviderNpisRankedSort { get; set; } = new List<string>();

    /// <summary>
    /// A list of rendering provider names to show first. This will return all charge captures with one of the names in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> RenderingProviderNamesRankedSort { get; set; } = new List<string>();

    /// <summary>
    /// A list of supervising provider NPIs to show first. This will return all charge captures with one of the NPIs in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> SupervisingProviderNpisRankedSort { get; set; } = new List<string>();

    /// <summary>
    /// A list of supervising provider names to show first. This will return all charge captures with one of the names in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> SupervisingProviderNamesRankedSort { get; set; } =
        new List<string>();

    /// <summary>
    /// the status of the claim to filter by created from charge capture bundle.
    /// </summary>
    [JsonIgnore]
    public ClaimStatus? ClaimStatus { get; set; }

    /// <summary>
    /// A list of claim creation categories to sort by. This will return all charge capture claim_creations which include one or more charges with one of the names in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ClaimCreationCategoryRankedSort { get; set; } = new List<string>();

    /// <summary>
    /// A list of tags. This will return all charge captures with one of the tags.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> TagsRankedSort { get; set; } = new List<string>();

    /// <summary>
    /// A list of primary payer names to sort by. This will return all charge captures with one of the names.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> PrimaryPayerNamesRankedSort { get; set; } = new List<string>();

    /// <summary>
    /// A list of patient names to sort by. This will return all charge captures with one of the names.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> PatientNamesRankedSort { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
