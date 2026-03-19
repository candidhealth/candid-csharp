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
}
