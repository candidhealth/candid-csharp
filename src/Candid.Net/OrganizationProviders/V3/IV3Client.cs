using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.OrganizationProviders.V3;

public partial interface IV3Client
{
    WithRawResponseTask<OrganizationProviderV2> GetAsync(
        string organizationProviderId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrganizationProviderPageV2> GetMultiAsync(
        GetAllOrganizationProvidersRequestV2 request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrganizationProviderV2> CreateAsync(
        OrganizationProviderCreateV2 request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrganizationProviderV2> UpdateAsync(
        string organizationProviderId,
        OrganizationProviderUpdateV2 request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Uploads a file to the provider. Accepted file types are W9, PECOS_RECORD, and BANK_LETTER_OR_VOIDED_CHECK.
    /// Only one file per type is allowed per provider — uploading when a file of the same type already exists returns a 409.
    /// </summary>
    WithRawResponseTask<string> UploadAttachmentAsync(
        string organizationProviderId,
        UploadProviderAttachmentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<IEnumerable<ProviderAttachment>> ListAttachmentsAsync(
        string organizationProviderId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ProviderAttachmentResponse> DownloadAttachmentAsync(
        DownloadProviderAttachmentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask DeleteAttachmentAsync(
        string attachmentId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
