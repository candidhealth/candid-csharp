using Candid.Net.Core;
using Candid.Net.OrganizationServiceFacilities.V2;

#nullable enable

namespace Candid.Net.OrganizationServiceFacilities;

public partial class OrganizationServiceFacilitiesClient
{
    private RawClient _client;

    internal OrganizationServiceFacilitiesClient(RawClient client)
    {
        _client = client;
        V2 = new V2Client(_client);
    }

    public V2Client V2 { get; }
}
