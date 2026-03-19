using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.Credentialing.V2;

public partial interface IV2Client
{
    WithRawResponseTask<FacilityCredentialingSpan> CreateFacilityAsync(
        FacilityCredentialingSpanCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<FacilityCredentialingSpan> GetFacilityAsync(
        string facilityCredentialingId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<FacilityCredentialingSpanPage> GetAllFacilitiesAsync(
        GetAllFacilityCredentialingSpansRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Soft deletes a credentialing span rate from the system.
    /// </summary>
    global::System.Threading.Tasks.Task DeleteFacilityAsync(
        string facilityCredentialingId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<FacilityCredentialingSpan> UpdateFacilityAsync(
        string facilityCredentialingId,
        FacilityCredentialingSpanUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ProviderCredentialingSpan> CreateAsync(
        ProviderCredentialingSpanCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ProviderCredentialingSpan> GetAsync(
        string providerCredentialingId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ProviderCredentialingSpanPage> GetAllAsync(
        GetAllProviderCredentialingSpansRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Soft deletes a credentialing span rate from the system.
    /// </summary>
    global::System.Threading.Tasks.Task DeleteAsync(
        string providerCredentialingId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ProviderCredentialingSpan> UpdateAsync(
        string providerCredentialingId,
        ProviderCredentialingSpanUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
