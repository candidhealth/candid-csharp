using Candid.Net;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Common;

namespace Candid.Net.PreEncounter.Patients.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Adds a patient.  VersionConflictError is returned when the patient's external ID is already in use.
    /// </summary>
    WithRawResponseTask<Patient> CreateAsync(
        CreatePatientRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Adds a patient and hydrates their MRN with a pre-existing MRN.  Once this patient is created their MRN will not be editable. BadRequestError is returned when the MRN is greater than 20 characters. VersionConflictError is returned when the patient's external ID is already in use.
    /// </summary>
    WithRawResponseTask<Patient> CreateWithMrnAsync(
        CreatePatientWithMrnRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Searches for patients that match the query parameters.
    /// </summary>
    WithRawResponseTask<PatientPage> GetMultiAsync(
        PatientsSearchRequestPaginated request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Searches for referring providers that match the query parameters.  The search is case-insensitive, supports fuzzy matching, and matches against provider name and NPI. The search criteria must be an alphanumeric string, and the search is limited to the first 20 results.
    /// </summary>
    WithRawResponseTask<IEnumerable<ExternalProvider>> SearchProvidersAsync(
        SearchProvidersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Gets a patient.
    /// </summary>
    WithRawResponseTask<Patient> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Gets a patient by mrn.
    /// </summary>
    WithRawResponseTask<Patient> GetByMrnAsync(
        string mrn,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Gets a patient along with it's full history.  The return list is ordered by version ascending.
    /// </summary>
    WithRawResponseTask<IEnumerable<Patient>> GetHistoryAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Gets a patient along with their coverages at a specific point in time. Note that the date passed in is only used to determine what the filing order was for that patient during that time. The actual data returned will always be the latest version of the patient and coverages.
    /// </summary>
    WithRawResponseTask<PatientCoverageSnapshot> GetCoverageSnapshotAsync(
        string id,
        GetCoverageSnapshotRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates a patient. The path must contain the next version number to prevent race conditions. For example, if the current version of the patient is n, you will need to send a request to this endpoint with `/{id}/n+1` to update the patient. Updating historic versions is not supported.
    /// </summary>
    WithRawResponseTask<Patient> UpdateAsync(
        string id,
        string version,
        MutablePatient request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sets a patient as deactivated.  The path must contain the most recent version plus 1 to prevent race conditions.  Deactivating historic versions is not supported.
    /// </summary>
    global::System.Threading.Tasks.Task DeactivateAsync(
        string id,
        string version,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Removes the deactivated flag for a patient.  The path must contain the most recent version plus 1 to prevent race conditions.  Reactivating historic versions is not supported.
    /// </summary>
    global::System.Threading.Tasks.Task ReactivateAsync(
        string id,
        string version,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a list of Patients based on the search criteria.
    /// </summary>
    WithRawResponseTask<IEnumerable<Patient>> SearchAsync(
        PatientGetMultiRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Scans up to 1000 patient updates. The since query parameter is inclusive, and the result list is ordered by updatedAt ascending.
    ///
    /// **Polling Pattern:**
    /// To continuously poll for updates without gaps:
    /// 1. Make your initial request with a `since` timestamp (e.g., `since=2020-01-01T13:00:00.000Z`)
    /// 2. The API returns 100 by default and up to 1000 patient records, sorted by `updated_at` ascending
    /// 3. Find the `updated_at` value from the last record in the response
    /// 4. Use that `updated_at` value as the `since` parameter in your next request
    /// 5. Repeat steps 2-4 to ingest updates until you receive an empty list
    ///
    /// **Important Notes:**
    /// - The `since` parameter is inclusive, so you may receive the last record from the previous batch again (you can deduplicate by ID and version)
    /// - All patient records include `updated_at`, `id`, `version`, `deactivated`, and `updating_user` fields for tracking changes
    /// - Timestamps have millisecond resolution for precise ordering
    /// </summary>
    WithRawResponseTask<IEnumerable<Patient>> ScanAsync(
        PatientScanRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
