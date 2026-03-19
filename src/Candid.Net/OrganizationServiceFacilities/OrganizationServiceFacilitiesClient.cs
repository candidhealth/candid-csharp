using Candid.Net.Core;

namespace Candid.Net.OrganizationServiceFacilities;

public partial class OrganizationServiceFacilitiesClient
{
    private RawClient _client;

    internal OrganizationServiceFacilitiesClient(RawClient client)
    {
        _client = client;
        V2 = new global::Candid.Net.OrganizationServiceFacilities.V2.V2Client(_client);
    }

    public global::Candid.Net.OrganizationServiceFacilities.V2.V2Client V2 { get; }
}
