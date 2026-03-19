using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.OrganizationServiceFacilities.V2;

public partial interface IV2Client
{
    WithRawResponseTask<OrganizationServiceFacility> GetAsync(
        string organizationServiceFacilityId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrganizationServiceFacilityPage> GetMultiAsync(
        GetAllOrganizationServiceFacilitiesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Looks up a single organization service facility by its `external_id` field. This can be useful
    /// for finding service facilities within Candid which are associated with service facilities in
    /// an external system.
    /// </summary>
    WithRawResponseTask<OrganizationServiceFacility> GetByExternalIdAsync(
        string externalId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrganizationServiceFacility> CreateAsync(
        OrganizationServiceFacilityCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OrganizationServiceFacility> UpdateAsync(
        string organizationServiceFacilityId,
        OrganizationServiceFacilityUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    global::System.Threading.Tasks.Task DeleteAsync(
        string organizationServiceFacilityId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
