using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.PatientMerges.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Creates a new patient merge record.
    /// </summary>
    WithRawResponseTask<PatientMerge> CreateAsync(
        MutablePatientMerge request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Gets the merge status for a patient by patient ID or mrn. If the provided value is a valid UUID, it will be treated as a patient ID. Otherwise, it will be treated as an MRN.
    /// </summary>
    WithRawResponseTask<PatientMergeStatus> GetStatusAsync(
        string mrnOrId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Gets all patient merge records that have the given mrn.
    /// </summary>
    WithRawResponseTask<IEnumerable<PatientMerge>> GetAllByMrnAsync(
        string mrn,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deactivates a patient merge record. Path must contain next version.
    /// </summary>
    WithRawResponseTask DeactivateAsync(
        string id,
        string version,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Scans up to 1000 patient merge updates. The since query parameter is inclusive, and the result list is ordered by updatedAt ascending.
    ///
    /// **Polling Pattern:**
    /// To continuously poll for updates without gaps:
    /// 1. Make your initial request with a `since` timestamp (e.g., `since=2020-01-01T13:00:00.000Z`)
    /// 2. The API returns 100 by default and up to 1000 patient merge records, sorted by `updated_at` ascending
    /// 3. Find the `updated_at` value from the last record in the response
    /// 4. Use that `updated_at` value as the `since` parameter in your next request
    /// 5. Repeat steps 2-4 to ingest updates until you receive an empty list
    ///
    /// **Important Notes:**
    /// - The `since` parameter is inclusive, so you may receive the last record from the previous batch again (you can deduplicate by ID and version)
    /// - All patient merge records include `updated_at`, `id`, `version`, `deactivated`, and `updating_user` fields for tracking changes
    /// - Timestamps have millisecond resolution for precise ordering
    /// </summary>
    WithRawResponseTask<IEnumerable<PatientMerge>> ScanAsync(
        PatientMergeScanRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
