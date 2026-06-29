using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.OrganizationExternalProviders.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Gets an organization external provider by ID.
    /// </summary>
    WithRawResponseTask<OrganizationExternalProvider> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Searches for organization external providers that match the query parameters.
    /// </summary>
    WithRawResponseTask<OrganizationExternalProviderPage> GetMultiAsync(
        OrganizationExternalProviderGetMultiRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a new organization external provider. BadRequestError is returned when the NPI is already in use.
    /// </summary>
    WithRawResponseTask<OrganizationExternalProvider> CreateAsync(
        MutableOrganizationExternalProvider request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates an organization external provider. The path must contain the next version number to prevent race conditions. For example, if the current version of the provider is n, you will need to send a request to this endpoint with `/{id}/n+1` to update the provider. Updating historic versions is not supported. BadRequestError is returned when the NPI is already in use by another provider.
    /// </summary>
    WithRawResponseTask<OrganizationExternalProvider> UpdateAsync(
        string id,
        string version,
        MutableOrganizationExternalProvider request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sets an organization external provider as deactivated. The path must contain the most recent version plus 1 to prevent race conditions. Deactivating historic versions is not supported.
    /// </summary>
    WithRawResponseTask DeactivateAsync(
        string id,
        string version,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Scans up to 1000 organization external provider updates. The since query parameter is inclusive, and the result list is ordered by updatedAt ascending.
    ///
    /// **Polling Pattern:**
    /// To continuously poll for updates without gaps:
    /// 1. Make your initial request with a `since` timestamp (e.g., `since=2020-01-01T13:00:00.000Z`)
    /// 2. The API returns 100 by default and up to 1000 records, sorted by `updated_at` ascending
    /// 3. Find the `updated_at` value from the last record in the response
    /// 4. Use that `updated_at` value as the `since` parameter in your next request
    /// 5. Repeat steps 2-4 to ingest updates until you receive an empty list
    ///
    /// **Important Notes:**
    /// - The `since` parameter is inclusive, so you may receive the last record from the previous batch again (you can deduplicate by ID and version)
    /// - All records include `updated_at`, `id`, `version`, `deactivated`, and `updating_user` fields for tracking changes
    /// - Timestamps have millisecond resolution for precise ordering
    /// </summary>
    WithRawResponseTask<IEnumerable<OrganizationExternalProvider>> ScanAsync(
        OrganizationExternalProviderScanRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
