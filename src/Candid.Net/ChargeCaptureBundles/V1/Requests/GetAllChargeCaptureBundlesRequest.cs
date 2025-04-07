using Candid.Net.ChargeCapture.V1;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCaptureBundles.V1;

public record GetAllChargeCaptureBundlesRequest
{
    /// <summary>
    /// Maximum number of entities per page, defaults to 100.
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// Defaults to created_at
    /// </summary>
    public ChargeCaptureBundleSortField? Sort { get; set; }

    /// <summary>
    /// Sort direction. Defaults to descending order if not provided.
    /// </summary>
    public SortDirection? SortDirection { get; set; }

    public string? PageToken { get; set; }

    /// <summary>
    /// The patient ID from the external EMR platform for the patient
    /// </summary>
    public string? PatientExternalId { get; set; }

    /// <summary>
    /// the status of the charge capture bundle, refers to whether it was able to create an encounter.
    /// </summary>
    public ChargeCaptureBundleStatus? BundleStatus { get; set; }

    /// <summary>
    /// the status of the charge captures
    /// </summary>
    public ChargeCaptureStatus? ChargeStatus { get; set; }

    /// <summary>
    /// A client-specified unique ID to associate with this encounter;
    /// for example, your internal encounter ID or a Dr. Chrono encounter ID.
    /// This field should not contain PHI.
    /// </summary>
    public string? ChargeExternalId { get; set; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-24.
    /// This date must be the local date in the timezone where the service occurred.
    /// </summary>
    public DateOnly? DateOfService { get; set; }

    /// <summary>
    /// If true, only return bundles that have charge captures that have been updated since the bundle has had a status of BILLED. See the updates property on ChargeCapture for more details.
    /// </summary>
    public bool? HasChargeCaptureUpdates { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
