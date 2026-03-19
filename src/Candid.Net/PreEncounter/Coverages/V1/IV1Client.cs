using global::Candid.Net;
using global::Candid.Net.Core;
using global::Candid.Net.PreEncounter.EligibilityChecks.V1;

namespace Candid.Net.PreEncounter.Coverages.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Creates a new Coverage. A Coverage provides the high-level identifiers and descriptors of a specific insurance plan for a specific individual - typically the information you can find on an insurance card. Additionally a coverage will include detailed benefits information covered by the specific plan for the individual.
    /// </summary>
    WithRawResponseTask<Coverage> CreateAsync(
        MutableCoverage request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates a Coverage. The path must contain the next version number to prevent race conditions. For example, if the current version of the coverage is n, you will need to send a request to this endpoint with `/{id}/n+1` to update the coverage. Updating historic versions is not supported.
    /// </summary>
    WithRawResponseTask<Coverage> UpdateAsync(
        string id,
        string version,
        MutableCoverage request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a page of Coverages based on the search criteria.
    /// </summary>
    WithRawResponseTask<CoveragesPage> GetMultiPaginatedAsync(
        CoverageGetMultiPaginatedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// gets a specific Coverage
    /// </summary>
    WithRawResponseTask<Coverage> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Gets a coverage's history. Full history is returned if no filters are
    /// defined. The return list is ordered by version, defaulting to ascending.
    /// </summary>
    WithRawResponseTask<IEnumerable<Coverage>> GetHistoryAsync(
        string id,
        CoveragesGetHistoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a list of Coverages based on the search criteria.
    /// </summary>
    WithRawResponseTask<IEnumerable<Coverage>> GetMultiAsync(
        CoverageGetMultiRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Scans up to 100 coverage updates. The since query parameter is inclusive, and the result list is ordered by updatedAt ascending.
    ///
    /// **Polling Pattern:**
    /// To continuously poll for updates without gaps:
    /// 1. Make your initial request with a `since` timestamp (e.g., `since=2020-01-01T13:00:00.000Z`)
    /// 2. The API returns up to 100 coverage records, sorted by `updated_at` ascending
    /// 3. Find the `updated_at` value from the last record in the response
    /// 4. Use that `updated_at` value as the `since` parameter in your next request
    /// 5. Repeat steps 2-4 to ingest updates until you receive an empty list
    ///
    /// **Important Notes:**
    /// - The `since` parameter is inclusive, so you may receive the last record from the previous batch again (you can deduplicate by ID and version)
    /// - All coverage records include `updated_at`, `id`, `version`, `deactivated`, and `updating_user` fields for tracking changes
    /// - Timestamps have millisecond resolution for precise ordering
    /// </summary>
    WithRawResponseTask<IEnumerable<Coverage>> ScanAsync(
        CoverageScanRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Finds all coverages associated with the given ppg_id and updates the ppg_fields for each coverage.
    /// </summary>
    global::System.Threading.Tasks.Task BatchUpdatePpgAsync(
        string ppgId,
        PayerPlanGroupFields request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Initiates an eligibility check. Returns the metadata of the check if successfully initiated.
    /// </summary>
    WithRawResponseTask<EligibilityCheckMetadata> CheckEligibilityAsync(
        string id,
        CheckEligibilityRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Gets the eligibility of a patient for a specific coverage if successful.
    /// </summary>
    WithRawResponseTask<CoverageEligibilityCheckResponse> GetEligibilityAsync(
        string id,
        string checkId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
