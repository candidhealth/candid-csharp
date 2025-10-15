using System.Text.Json.Serialization;
using Candid.Net.ChargeCapture.V1;
using Candid.Net.Claims;
using Candid.Net.Core;

namespace Candid.Net.ChargeCaptureBundles.V1;

[Serializable]
public record GetAllChargeCaptureClaimCreationsRequest
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
    public ChargeCaptureClaimCreationSortField? Sort { get; set; }

    /// <summary>
    /// Sort direction. Defaults to descending order if not provided.
    /// </summary>
    [JsonIgnore]
    public global::Candid.Net.Commons.SortDirection? SortDirection { get; set; }

    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <summary>
    /// The patient ID from the external EMR platform for the patient
    /// </summary>
    [JsonIgnore]
    public string? PatientExternalId { get; set; }

    /// <summary>
    /// the status of the charge capture Claim Creation, refers to whether it was able to create a claim.
    /// </summary>
    [JsonIgnore]
    public ChargeCaptureClaimCreationStatus? ClaimCreationStatus { get; set; }

    /// <summary>
    /// the status of the charge captures
    /// </summary>
    [JsonIgnore]
    public ChargeCaptureStatus? ChargeStatus { get; set; }

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
    /// A list of claim IDs to filter by. This will return all charge capture claim_creations that have a resulting claim with one of the IDs in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ClaimIds { get; set; } = new List<string>();

    /// <summary>
    /// A list of Claim Creation IDs to filter by.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ClaimCreationIds { get; set; } = new List<string>();

    /// <summary>
    /// A list of billing provider NPIs to filter by. This will return all charge capture claim_creations which include one or more charges with one of the NPIs in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> BillingProviderNpis { get; set; } = new List<string>();

    /// <summary>
    /// A string to filter by. This will return all charge capture claim_creations which include one or more charges with this service facility name.
    /// </summary>
    [JsonIgnore]
    public string? ServiceFacilityName { get; set; }

    /// <summary>
    /// A list of primary payer IDs to filter by. This will return all charge capture claim_creations which include one or more charges with one of the primary payer IDs in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> PrimaryPayerIds { get; set; } = new List<string>();

    /// <summary>
    /// A list of rendering provider NPIs to filter by. This will return all charge capture claim_creations which include one or more charges with one of the NPIs in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> RenderingProviderNpis { get; set; } = new List<string>();

    /// <summary>
    /// A list of rendering provider names to filter by. This will return all charge capture claim_creations which include one or more charges with one of the names in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> RenderingProviderNames { get; set; } = new List<string>();

    /// <summary>
    /// A list of supervising provider NPIs to filter by. This will return all charge capture claim_creations which include one or more charges with one of the NPIs in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> SupervisingProviderNpis { get; set; } = new List<string>();

    /// <summary>
    /// A list of supervising provider names to filter by. This will return all charge capture claim_creations which include one or more charges with one of the names in this list.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> SupervisingProviderNames { get; set; } = new List<string>();

    /// <summary>
    /// the status of the claim to filter by created from charge capture bundle.
    /// </summary>
    [JsonIgnore]
    public ClaimStatus? ClaimStatus { get; set; }

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
    /// If true, only return claim_creations that have charge captures that have been updated since the Claim Creation has had a status of BILLED. See the updates property on ChargeCapture for more details.
    /// </summary>
    [JsonIgnore]
    public bool? HasChargeCaptureUpdates { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
